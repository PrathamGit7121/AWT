using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml.Linq;
using System.CodeDom;
using System.IO;

namespace AWT_Pract_Three
{
    public partial class Insert_DB : System.Web.UI.Page
    {
        static string conStr =ConfigurationManager.ConnectionStrings["DemoConnectionString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        public void ClearTextBox()
        {
            txtRollNo.Text = " ";
            txtName.Text = " ";
            txtAddress.Text = " ";
            txtSearch.Text = " ";
        }
        public SqlCommand GetCmd()
        {
            return cmd;
        }

        public void showData() 
        {
            try 
            {
                cmd = new SqlCommand("SELECT * FROM stud", conn);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                Stud_GridView.DataSource = dt;
                Stud_GridView.DataBind();
            }catch (Exception ex)
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
                if (txtRollNo.Text != "" && txtName.Text != "" && txtAddress.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO stud(rollno,name,address)VALUES(@roll, @nm, @add)", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@roll", txtRollNo.Text);
                    cmd.Parameters.AddWithValue("@nm", txtName.Text);
                    cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        Message_label.Text = "Record inserted Successfully!";
                    }
                    else
                    {
                        Message_label.Text = "Record not inserted!";
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
                conn.Close();
                ClearTextBox();
                showData();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e) 
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM stud WHERE rollno=@search", conn);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@search", txtSearch.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Message_label.Text = "Record found Successfully!";
                    ClearTextBox();
                    txtRollNo.Text = dr["rollno"].ToString();
                    txtName.Text = dr["name"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                }
                else
                {
                    Message_label.Text = "Record not found";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {

            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("DELETE stud WHERE rollno=@sid", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@sid", txtSearch.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    Message_label.Text = "Record deleted Successfully!";
                }
                else
                {
                    Message_label.Text = "Record not deleted!";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                ClearTextBox();
                showData();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e) 
        {
            try
            {
                if (txtRollNo.Text != " " && txtName.Text != " " && txtAddress.Text != " ")
                {
                    cmd = new SqlCommand("UPDATE stud SET name=@nm, address=@add WHERE rollno=@roll", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@nm", txtName.Text);
                    cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        Message_label.Text = "Record updated Successfully!";
                    }
                    else
                    {
                        Message_label.Text = "Record not updated!";
                    }
                }
                else
                {
                    Message_label.Text = "Please enter data!";
                }
            }
            catch (Exception ex)
            {
                Message_label.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                ClearTextBox();
                showData();
            }
        }
    }
}