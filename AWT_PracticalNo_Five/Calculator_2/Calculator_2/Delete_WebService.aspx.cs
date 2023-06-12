using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Calculator_2
{
    public partial class Delete_WebService : System.Web.UI.Page
    {
        ServiceReference4.Delete_WebServiceSoapClient proxy1 = new ServiceReference4.Delete_WebServiceSoapClient();
        DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        {
            dt = proxy1.DisplayAllRecord();
            gvproduct.DataSource = dt;
            gvproduct.DataBind();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            gvproduct.DataSource = dt;
            gvproduct.DataBind();
            int id = Convert.ToInt32(txtPid.Text);
            string name = txtPid.Text;
            string details = txtPdetails.Text;
            string price = txtPrice.Text;
            lblMessage.Text = proxy1.DeleteRecord(id, name, details, price);
            dt = proxy1.DisplayAllRecord();
            gvproduct.DataSource = dt;
            gvproduct.DataBind();
        }
    }
}