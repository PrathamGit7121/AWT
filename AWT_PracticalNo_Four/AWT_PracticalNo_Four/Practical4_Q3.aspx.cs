using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Practical4_Q3 : System.Web.UI.Page
    {
        int cmt;
        protected void Page_Load(object sender, EventArgs e)
        {
            cmt = Convert.ToInt32(Server.UrlDecode(Request.QueryString["count"]));

            if(cmt != 0)
            {
                cmt = cmt + 1;
            }
            else
            {
                cmt = 1;
            }
            lblCounter.Text = Convert.ToString(cmt);
        }
    }
}