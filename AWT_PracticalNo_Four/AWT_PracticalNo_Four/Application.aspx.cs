using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitorCoutn.Text = "No of times site visited = " + Application["SiteVisitCounter"];
            lblOnlineVisitorCounter.Text = "no of users online site visited = " + Application["OnlineUserCounter"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}