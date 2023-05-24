using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Session_State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["FirstName"] = txtFname.Text;
            Session["LastName"] = txtLname.Text;
            Response.Redirect("SessionStateDemo02.aspx");
        }
    }
}