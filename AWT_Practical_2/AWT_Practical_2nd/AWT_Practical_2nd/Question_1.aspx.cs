using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practical_2nd
{
    public partial class Question_1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br/>" + "PreInit";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "Init";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "InitComplete";
        }
        protected void OnPreLoad(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "PreLoad";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "Load";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "btnSubmit_Click";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {

            lblName.Text = lblName.Text + "<br />" + "LoadComplete";
        }
        protected override void OnPreRender(EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "InitComplete";
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "OnSaveStateComplete";
        }
        protected void page_UnLoad(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br />" + "UnLoad";
        }
    }
}