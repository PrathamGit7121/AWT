using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practical_2nd
{
    public partial class Question_3_3 : System.Web.UI.Page
    {
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}