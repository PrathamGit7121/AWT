using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWT_Practial_Three
{
    public partial class Practical3_Q2 : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["CustomerConnectionString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        SqlCommandBuilder builder = null;
        DataSet ds = null;

        public void clearTextBox()
        {
            TxtEid.Text = "";
            TxtEName.Text = "";
            TxtEDesignation.Text = "";
            TxtESalary.Text = "";
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
                cmd = new SqlCommand("Select * from emp_info", conn);
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds, "emp_info");
                gvEmployeeDetails.DataSource = ds.Tables["emp_info"];
                gvEmployeeDetails.DataBind();
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception!" + ex.Message;
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
                if (TxtEid.Text != "" && TxtEName.Text != "" && TxtEDesignation.Text != "" && TxtESalary.Text != "")

                {
                    builder = new SqlCommandBuilder(da);
                    DataRow drNew = ds.Tables["emp_info"].NewRow();
                    drNew[0] = TxtEid.Text;
                    drNew[1] = TxtEName.Text;
                    drNew[2] = TxtEDesignation.Text;
                    drNew[3] = TxtESalary.Text;
                    ds.Tables["emp_info"].Rows.Add(drNew);
                    builder.GetInsertCommand();
                    int r = da.Update(ds, "emp_info");
                    if (r != 0)
                    {
                        MsgLabel.Text = "Record Inserted Successfully";
                    }
                    else
                    {
                        MsgLabel.Text = "Record Not Inserted";
                    }
                }
                else
                {
                    MsgLabel.Text = "Please enter all details";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception!" + ex.Message;
            }
            finally
            {
                conn.Close();
                clearTextBox();
                showData();
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtEid.Text != "")
                {
                    builder = new SqlCommandBuilder(da);
                    DataRow drDelete = ds.Tables["emp_info"].Rows.Find(Convert.ToInt32(TxtEid.Text));

                    drDelete.Delete();
                    builder.GetDeleteCommand();
                    int r = da.Update(ds, "emp_info");
                    if (r != 0)
                    {
                        MsgLabel.Text = "Record Delted Successfully!";
                    }
                    else
                    {
                        MsgLabel.Text = "Record Not Deleted";
                    }
                }
                else
                {
                    MsgLabel.Text = "Enter Roll No.!";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception!" + ex.Message;
            }
            finally
            {
                conn.Close();
                clearTextBox();
                showData();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEid.Text != "" && TxtEName.Text != "" && TxtEDesignation.Text != "" && TxtESalary.Text != "")
                {

                    builder = new SqlCommandBuilder(da);
                    DataRow drUpdate = ds.Tables[0].Rows.Find(Convert.ToInt32(TxtEid.Text));
                    drUpdate[1] = TxtEName.Text;
                    drUpdate[2] = TxtEDesignation.Text;
                    drUpdate[3] = TxtESalary.Text;
                    builder.GetUpdateCommand();
                    int r = da.Update(ds, "emp_info");
                    if (r != 0)
                    {
                        MsgLabel.Text = "Record Updated Successfuly!";
                    }
                    else
                    {
                        MsgLabel.Text = "Record Not Updated!";
                    }
                }
                else
                {
                    MsgLabel.Text = "Please Enter Details!";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception!" + ex.Message;
            }
            finally
            {
                conn.Close();
                clearTextBox();
                showData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSearch.Text != "")
                {
                    DataRow drSearch = ds.Tables[0].Rows.Find(Convert.ToInt32(TxtSearch.Text));
                    if (drSearch != null)
                    {
                        MsgLabel.Text = "Record Found Successfully!";
                        clearTextBox();
                        TxtEid.Text = drSearch[0].ToString();
                        TxtEName.Text = drSearch[1].ToString();
                        TxtEDesignation.Text = drSearch[2].ToString();
                        TxtESalary.Text = drSearch[3].ToString();
                    }
                    else
                    {
                        MsgLabel.Text = "Record not Found";
                    }
                }
                else
                {
                    MsgLabel.Text = "Please Enter Enter Employee Id";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception!" + ex.Message;
            }
        }
    }
}