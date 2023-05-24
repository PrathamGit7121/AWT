using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class http_Context_Demo : System.Web.UI.Page
    {
        HttpContext contex = HttpContext.Current;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnStore_Click(object sender, EventArgs e)
        {
            contex.Session["UserName"] = txtFname.Text;
            txtFname.Text = "";
        }
        protected void btnRetrive_Click(object sender, EventArgs e)
        {
            txtFname.Text = (contex.Session["UserName"].ToString());
        }
    }
}