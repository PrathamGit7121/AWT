using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class Pagination_AJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tmrPaging_Tick(object sender, EventArgs e)
        {
            if(grid_view.PageIndex != grid_view.PageCount-1)
            {
                grid_view.PageIndex=grid_view.PageIndex+1;
            }
            else
            {
                grid_view.PageIndex = 0;
            }
        }
    }
}