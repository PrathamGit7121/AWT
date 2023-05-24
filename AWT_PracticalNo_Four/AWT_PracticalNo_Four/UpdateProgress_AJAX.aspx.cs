using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class UpdateProgress_AJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt1.Text);
                int b = Convert.ToInt32(txt2.Text);
                System.Threading.Thread.Sleep(5000);
                int add = a + b;
                int sub = a - b;
                int mul = a * b;
                lbAdd.Text = "Addation: " + add.ToString();
                lbSub.Text = "Substraction: " + sub.ToString();
                lbMul.Text = "Multiplication: " + mul.ToString();
            }
            catch(Exception ex) {
                lblMessage.Text = "Exception! " + ex;
            }

        }
    }
}