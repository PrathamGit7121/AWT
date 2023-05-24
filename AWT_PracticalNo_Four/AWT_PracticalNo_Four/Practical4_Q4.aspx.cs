using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Practical4_Q4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Cache["FirstName"] = txtFname.Text;
            Cache["LastName"] = txtLname.Text;
            Response.Redirect("CacheDemo02.aspx");
        }

    }
}