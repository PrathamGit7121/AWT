using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Pract_Three
{
    public partial class Question_3 : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["DemoConnectionString"].ToString();
        DB_oneDataContext dc = new DB_oneDataContext(conStr);
        
        public void clearTextBox()
        {
            txtRollNo.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
        }
        public void showData()
        {
            try
            {
                var q = from a in dc.GetTable<stud>() select a;
                Stud_GridView.DataSource = q;
                Stud_GridView.DataBind();
            }
            catch(Exception ex)
            {
                Message_label.Text = "Exception "+ex.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception " + ex.Message;
            }
        }
    }
}