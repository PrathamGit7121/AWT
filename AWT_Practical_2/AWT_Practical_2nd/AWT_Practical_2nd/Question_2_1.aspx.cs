using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practical_2nd
{
    public partial class Question_2 : System.Web.UI.Page
    {
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            content.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnPostBackPostiong_Click(object sender, EventArgs e)
        {
            content.Text = "Hi " + txtName.Text + ", Here is output of the Same Page Post Back Button: " + Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }
    }
}