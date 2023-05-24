using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class BannerChange_Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tmrUpdateBanner_Tick(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            int n = RandomNumber.Next(1, 3);
            myImage.ImageUrl = string.Concat("img/FAMT", n.ToString(), ".jpg");
        }
    }
}