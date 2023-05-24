using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practial_Three
{
    public partial class Practical3_Q7 : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["CustomerConnectionString"].ToString();
        emp_infoLINQDataContextDataContext emp_dc = new emp_infoLINQDataContextDataContext(conStr);
        public void clearTextBox()
        {
            txtEid.Text = "";
            txtName.Text = "";
            txtDesg.Text = "";
            txtSalary.Text = "";
        }
        public void showData()
        {
            try
            {
                var q = from a in emp_dc.GetTable<emp_info>() select a;
                gridEmployee.DataSource = q;
                gridEmployee.DataBind();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                emp_info objAdd = new emp_info();
                objAdd.eid = Convert.ToInt16(txtEid.Text);
                objAdd.ename = Convert.ToString(txtName.Text);
                objAdd.designation = Convert.ToString(txtDesg.Text);
                objAdd.salary = Convert.ToString(txtSalary.Text);
                emp_dc.emp_infos.InsertOnSubmit(objAdd);
                emp_dc.SubmitChanges();
                clearTextBox();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
            finally
            {
                showData();
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                emp_info objDel = emp_dc.emp_infos.Single(emp_info => emp_info.eid == Convert.ToInt16(txtEid.Text));
                emp_dc.emp_infos.DeleteOnSubmit(objDel);
                emp_dc.SubmitChanges();
                clearTextBox();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
            finally
            {
                showData();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                emp_info objUpdate = emp_dc.emp_infos.Single(emp_info => emp_info.eid == Convert.ToInt16(txtEid.Text));
                objUpdate.ename = Convert.ToString(txtName.Text);
                objUpdate.designation = Convert.ToString(txtDesg.Text);
                objUpdate.salary = Convert.ToString(txtSalary.Text);
                emp_dc.SubmitChanges();
                clearTextBox();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
            finally
            {
                showData();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                emp_info objSearch = emp_dc.emp_infos.Single(emp_info => emp_info.eid == Convert.ToInt16(txtEid.Text));
                txtEid.Text = Convert.ToString(objSearch.eid);
                txtName.Text = objSearch.ename;
                txtDesg.Text = objSearch.designation;
                txtSalary.Text = objSearch.salary;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
        }
    }
}