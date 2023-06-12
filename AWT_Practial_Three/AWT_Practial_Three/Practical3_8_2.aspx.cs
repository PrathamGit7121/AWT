using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practial_Three
{
    public partial class Practical3_8_2 : System.Web.UI.Page
    {
        customer_info_Entities1 db = new customer_info_Entities1();

        public void clearTextBox()
        {
            txtPid.Text = "";
            txtPname.Text = "";
            txtPcost.Text = "";
        }
        public void showData()
        {
            try
            {
                gridProduct.DataSource = db.ProductDetails.ToList();
                gridProduct.DataBind();
            }
            catch(Exception ex)
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
                ProductDetail prodobj = new ProductDetail();
                prodobj.pid = Convert.ToInt32(txtPid.Text);
                prodobj.pname = txtPname.Text;
                prodobj.pcost = txtPcost.Text;

                db.ProductDetails.Add(prodobj);
                db.SaveChanges();
                lblMessage.Text = "Record added Successfully!";
                showData();
                clearTextBox();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetail delobj = db.ProductDetails.Find(Convert.ToInt32(txtPid.Text));
                if(delobj != null)
                {
                    db.ProductDetails.Remove(delobj);
                    db.SaveChanges();
                    lblMessage.Text = "Record Deleted Successfully!";
                    showData();
                    clearTextBox();
                }
                else
                {
                    lblMessage.Text = "Record not Found";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductDetail updateobj = db.ProductDetails.Find(Convert.ToInt32(txtPid.Text));
            try
            {
                if (updateobj != null)
                {
                    updateobj.pname = txtPid.Text;
                    updateobj.pcost = txtPcost.Text;
                    db.SaveChanges();
                    lblMessage.Text = "Record Update Successfully!";
                    showData();
                    clearTextBox();
                }
                else
                {
                    lblMessage.Text = "Record Not Found";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ProductDetail searchobj = db.ProductDetails.Find(Convert.ToInt32(txtPid.Text));
            try
            {
                if(searchobj != null)
                {
                    txtPid.Text = searchobj.pid.ToString();
                    txtPname.Text = searchobj.pname.ToString();
                    txtPcost.Text = searchobj.pcost.ToString();
                    lblMessage.Text = "Record Found Successfully!";
                }
                else
                {
                    lblMessage.Text = "Record Not Found!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
        }
    }
}