using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator_2
{
    public partial class ArithmaticCalculator : System.Web.UI.Page
    {
        ServiceReference1.CalculatorWebServicesSoapClient proxy1 = new ServiceReference1.CalculatorWebServicesSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result : Addition is " + proxy1.AddNum(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
        }
        protected void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result : Substraction in " + proxy1.SubNum(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
        }
        protected void btnMul_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result : Multiplication is " + proxy1.MulNum(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
        }
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result : Division is " + proxy1.DivNum(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
        }
    }
}