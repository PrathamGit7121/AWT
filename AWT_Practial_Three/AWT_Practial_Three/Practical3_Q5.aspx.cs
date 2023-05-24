using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practial_Three
{
    public partial class Practical3_Q5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            string[] my_words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            foreach (string s in my_words)
            {
                lblInput.Text = lblInput.Text + " " + s;
            }
            var shortWords = from word in my_words where word.Length <= 5 select word;
            foreach (var word in shortWords)
            {
                lblWords.Text = lblWords.Text + " " + word;
            }
        }
    }
}