using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practical_2nd
{
    public partial class Question_2_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                Calendar cal1 = new Calendar();
                TextBox txtMyName = new TextBox();
                cal1 = (Calendar)(PreviousPage.FindControl("Calendar1"));
                txtMyName = (TextBox)(PreviousPage.FindControl("txtName"));
                Label2.Text = "<br />Hi " + txtMyName.Text + ",Here is output of the Page Post Back Button:" + cal1.SelectedDate.ToString("dd/MM/yyyy");
            }
        }
    }
}