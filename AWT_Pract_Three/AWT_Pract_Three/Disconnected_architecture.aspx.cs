using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Pract_Three
{
    public partial class Disconnected_architecture : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["DemoConnectionString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        SqlCommandBuilder builder = null;
        DataSet ds = null;

        public void ClearTextBox()
        {
            txtRollNo.Text = " ";
            txtName.Text = " ";
            txtAddress.Text = " ";
        }

        public void showData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter();
                ds = new DataSet();
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cmd = new SqlCommand("Select * from stud", conn);
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds, "Db_one");
                Stud_GridView.DataSource = ds.Tables["Db_one"];
                Stud_GridView.DataBind();
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            showData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtRollNo.Text != " " && txtName.Text != " " && txtAddress.Text != " ")
                {
                    builder = new SqlCommandBuilder(da);
                    DataRow drNew = ds.Tables["Db_one"].NewRow();

                    drNew[0] = txtRollNo.Text;
                    drNew[1] = txtName.Text;
                    drNew[2] = txtAddress.Text;

                    ds.Tables["Db_one"].Rows.Add(drNew);
                    builder.GetInsertCommand();
                    int r = da.Update(ds, "Db_one");
                    if (r != 0)
                    {
                        Message_label.Text = "Record inserted Successfully!";
                    }
                    else
                    {
                        Message_label.Text = "Record not inserted!";
                    }
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                ClearTextBox();
                conn.Close(); 
                showData();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRollNo.Text != " ")
                {
                    builder = new SqlCommandBuilder(da);
                    DataRow drDelete = ds.Tables["Db_one"].Rows.Find(Convert.ToInt32(txtRollNo.Text));

                    drDelete.Delete();
                    builder.GetDeleteCommand();
                    int r = da.Update(ds, "Db_one");
                    if (r != 0)
                    {

                        Message_label.Text = "Record Deleted Successfully!";
                    }
                    else
                    {
                        Message_label.Text = "Record not Deleted!";
                    }
                }
                else
                {
                    Message_label.Text = "Please enter all details!";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                ClearTextBox();
                conn.Close();
                showData();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRollNo.Text != " " && txtName.Text != " " && txtAddress.Text != " ")
                {
                    builder = new SqlCommandBuilder(da);
                    DataRow drUpdate = ds.Tables[0].Rows.Find(Convert.ToInt32(txtRollNo.Text));
                    drUpdate[0] = txtRollNo.Text;
                    drUpdate[1] = txtName.Text;
                    drUpdate[2] = txtAddress.Text;
                    builder.GetUpdateCommand();
                    int r = da.Update(ds, "Db_one");
                    if (r != 0)
                    {

                        Message_label.Text = "Record Updated Successfully!";
                    }
                    else
                    {
                        Message_label.Text = "Record not Updated!";
                    }
                }
                else
                {
                    Message_label.Text = "Please enter all details!";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                ClearTextBox();
                conn.Close();
                showData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != " ")
                {
                    DataRow drSearch = ds.Tables[0].Rows.Find(Convert.ToInt32(txtSearch.Text));
                    if (drSearch != null)
                    {
                        Message_label.Text = "Record Found Successfully!";
                        txtRollNo.Text = drSearch[0].ToString();
                        txtName.Text = drSearch[1].ToString();
                        txtAddress.Text = drSearch[2].ToString();
                    }
                    else
                    {
                        Message_label.Text = "Record Not Found";
                    }
                }
                else
                {
                    Message_label.Text = "Please Enter Roll No.";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                showData();
            }
        }
    }
}