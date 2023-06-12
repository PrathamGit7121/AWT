using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practical_2nd
{
    public partial class Question_4_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox name = new TextBox();
                TextBox password = new TextBox();
                TextBox age = new TextBox();
                TextBox email = new TextBox();
                name = (TextBox)(PreviousPage.FindControl("txtName"));
                password = (TextBox)(PreviousPage.FindControl("txtPassword"));
                age = (TextBox)(PreviousPage.FindControl("txtAge"));
                email = (TextBox)(PreviousPage.FindControl("txtEmail"));
                lblName.Text = name.Text;
                lblPassword.Text = password.Text;
                lblAge.Text = age.Text;
                lblEmail.Text = email.Text;
            }
        }
    }
}