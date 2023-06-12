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
    public partial class Display_GridView_2 : System.Web.UI.Page
    {
        ServiceReference2.Display_GridviewSoapClient proxy1 = new ServiceReference2.Display_GridviewSoapClient();
        DataTable dt = null;
        public void showData()
        {
            dt = proxy1.DisplayAllRecord();
            gvemp.DataSource = dt;
            gvemp.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtEid.Text);
            string name = txtEname.Text;
            string salary = txtEsalary.Text;
            lblMessage.Text = proxy1.insertRecord(id, name, salary);

        }
    }
}