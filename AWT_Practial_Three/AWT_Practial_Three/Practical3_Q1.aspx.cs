using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Security.Cryptography;

namespace AWT_Practial_Three
{
    public partial class Practical3_Q1 : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["CustomerConnectionString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;
        public void clearTextBox()
        {
            TxtCId.Text = "";
            TxtCName.Text = "";
            TxtCAddress.Text = "";
        }
        public void showData()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM customer_info", conn);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable();
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                gvCustomerDetails.DataSource = dt;
                gvCustomerDetails.DataBind();
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception" + ex.Message;
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
                if (TxtCId.Text != "" && TxtCName.Text != "" && TxtCAddress.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO customer_info(cid,cname,cadd)VALUES(@cid, @cname, @cadd)", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@cid", TxtCId.Text);
                    cmd.Parameters.AddWithValue("@cname", TxtCName.Text);
                    cmd.Parameters.AddWithValue("@cadd", TxtCAddress.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MsgLabel.Text = "Record inserted Successfully!";
                    }
                    else
                    {
                        MsgLabel.Text = "Record not inserted!";
                    }
                }
                else
                {
                    MsgLabel.Text = "Please enter all details";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception" + ex.Message;
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
                if (TxtCId.Text != "" && Convert.ToUInt16(TxtCId.Text) > 0)
                {
                    cmd = new SqlCommand("DELETE customer_info WHERE cid=@cid", conn);
                    if (conn.State == ConnectionState.Closed)
                    { conn.Open(); }
                    cmd.Parameters.AddWithValue("@cid", TxtCId.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MsgLabel.Text = "Record Delted Successfully!";
                    }
                    else
                    {
                        MsgLabel.Text = "Record not deleted";
                    }
                }
                else
                {
                    MsgLabel.Text = "Please enter correct Customer Id";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception" + ex.Message;
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
                if (TxtCId.Text != "" && TxtCName.Text != "" && TxtCAddress.Text != "")
                {
                    cmd = new SqlCommand("UPDATE customer_info SET cname=@cname,cadd=@cadd WHERE cid = @cid", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@cid", TxtCId.Text);
                    cmd.Parameters.AddWithValue("@cname", TxtCName.Text);
                    cmd.Parameters.AddWithValue("@cadd", TxtCAddress.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MsgLabel.Text = "Record updated Successfully!";

                    }
                    else
                    {
                        MsgLabel.Text = "Record not Updated";
                    }
                }
                else
                {
                    MsgLabel.Text = "Please enter Details";
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Exception" + ex.Message;
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
                cmd = new SqlCommand("SELECT * FROM customer_info WHERE cid = @cid", conn);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@cid", TxtSearch.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MsgLabel.Text = "Record Found Successfully!";
                    clearTextBox();
                    TxtCId.Text = dr["cid"].ToString();
                    TxtCName.Text = dr["cname"].ToString();
                    TxtCAddress.Text = dr["cadd"].ToString();
                }
                else
                {
                    MsgLabel.Text = "Record Not Found";
                }
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
    }
}