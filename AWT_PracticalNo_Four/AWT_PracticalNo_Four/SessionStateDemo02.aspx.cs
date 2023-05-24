using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class SessionStateDemo02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["FirstName"] != null && Session["LastName"] != null)
                {
                    lbUser.Text = Session["FirstName"].ToString();
                    lbFirstName.Text = Session["FirstName"].ToString();
                    lbLastName.Text = Session["LastName"].ToString();
                }
                else
                {
                    lbFirstName.Text = "Session for FirstName key is not set";
                    lbLastName.Text = "Session for LaststName key is not set";
                }
            }
        }
    }
}