using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_PracticalNo_Four
{
    public partial class GridViewUsingAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (GridView1.PageIndex != GridView1.PageCount - 1)
            { GridView1.PageIndex = GridView1.PageIndex + 1; }
            else
            { GridView1.PageIndex = 0; }
        }
        protected void SqlDataSource1_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}