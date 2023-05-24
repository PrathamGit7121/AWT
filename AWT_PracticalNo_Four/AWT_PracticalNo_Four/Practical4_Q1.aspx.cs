using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Practical4_Q1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitAgain.Text = string.Format("Clicked {0} times!", hidFieldCount.Value);
        }

        protected void btnVisitAgain_Click_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if(hidFieldCount.Value == null)
                {
                    hidFieldCount.Value = 1.ToString();
                }
                else
                {
                    hidFieldCount.Value = (Convert.ToInt32(hidFieldCount.Value) + 1).ToString();
                }
            }
        }
    }
}