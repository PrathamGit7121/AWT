using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practial_Three
{
    public partial class Practical3_Q6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSelectOdd_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int n in numbers)
            {
                lblInput.Text = lblInput.Text + " " + n;
            }
            IEnumerable<int> numQuery = from num in numbers where (num % 2) != 0 select num;
            foreach (int n in numQuery)
            { 
                lblAns.Text = lblAns.Text + " " + n.ToString(); 
            }

        }
    }
}