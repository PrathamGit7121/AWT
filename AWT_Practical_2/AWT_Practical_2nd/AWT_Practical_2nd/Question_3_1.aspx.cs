using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practical_2nd
{
    public partial class Question_3_1 : System.Web.UI.Page
    {
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    FileUpload1.SaveAs("D:\\" + FileUpload1.FileName);
                    lblUploadStatus.Text = "File Upload Successfully!!" + FileUpload1.PostedFile.ContentLength + "mb"; ;
                }
                catch (Exception ex) 
                {
                    lblUploadStatus.Text = "File not Uploaded Successfully!!" + ex.Message.ToString();
                }
            }
            else
            {
                lblUploadStatus.Text = "Please Select File and Upload Again";
            }
        }
    }
}