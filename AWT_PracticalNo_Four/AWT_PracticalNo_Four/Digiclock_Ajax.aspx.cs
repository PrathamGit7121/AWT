using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Digiclock_Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void tmrDigiClock_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}