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
    public partial class Update_WebServices_1 : System.Web.UI.Page
    {
        ServiceReference3.Update_WebServiceSoapClient proxy1 = new ServiceReference3.Update_WebServiceSoapClient();
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
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            gvproduct.DataSource = dt;
            gvproduct.DataBind();
            int id = Convert.ToInt32(txtPid.Text);
            string name = txtPname.Text;
            string details = txtPdetails.Text;
            string price = txtPrice.Text;
            lblMessage.Text = proxy1.UpdateProduct(id, name, details, price);
            dt = proxy1.DisplayAllRecord();
            gvproduct.DataSource = dt;
            gvproduct.DataBind();
        }
    }
}
