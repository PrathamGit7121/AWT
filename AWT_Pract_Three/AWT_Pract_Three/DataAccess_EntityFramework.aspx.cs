using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Pract_Three
{
    public partial class DataAccess_EntityFramework : System.Web.UI.Page
    {
        Db_oneEntities1 db_OneEntities1 = new Db_oneEntities1();

        public void clearTextBox()
        {
            txtRollNo.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
        }

        public void showData()
        {
            try
            {
                Stud_GridView.DataSource = db_OneEntities1.studs.ToList();
                Stud_GridView.DataBind();
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception " + ex.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                stud studObjAdd = new stud();

                studObjAdd.rollno = (byte)Convert.ToInt32(txtRollNo.Text);
                studObjAdd.name = txtName.Text;
                studObjAdd.address = txtAddress.Text;

                db_OneEntities1.studs.Add(studObjAdd);

                db_OneEntities1.SaveChanges();

            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception " + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                stud studObjDel = db_OneEntities1.studs.Find((byte)Convert.ToInt32(txtRollNo.Text));
                if(studObjDel != null)
                {
                    db_OneEntities1.studs.Remove(studObjDel);
                    db_OneEntities1.SaveChanges();

                    Message_label.Text = "Record deleted successfully!";

                    showData();
                    clearTextBox();
                }
                else
                {
                    Message_label.Text = "Record not found!";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception " + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                stud studObjUpdate = db_OneEntities1.studs.Find((byte)Convert.ToInt32(txtRollNo.Text));
                if (studObjUpdate != null)
                {
                    studObjUpdate.name = txtName.Text;
                    studObjUpdate.address = txtAddress.Text;

                    db_OneEntities1.SaveChanges();

                    Message_label.Text = "Record Update successfully!";

                    showData();
                    clearTextBox();
                }
                else
                {
                    Message_label.Text = "Record not found!";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception " + ex.Message;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            

        }
    }
}