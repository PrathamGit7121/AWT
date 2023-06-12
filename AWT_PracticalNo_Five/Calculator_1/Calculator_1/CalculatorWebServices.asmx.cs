using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator_1
{
    /// <summary>
    /// Summary description for CalculatorWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string AddNum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total.ToString();
        }

        [WebMethod]
        public string SubNum(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total.ToString();
        }

        [WebMethod]
        public string MulNum(int num1, int num2)
        {
            int total;
            total = num1 * num2; 
            return total.ToString();
        }

        [WebMethod]
        public string DivNum(int num1, int num2)
        {
            int total;
            total = num1 / num2;
            return total.ToString();
        }
    }
}
