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
    public partial class Practical3_Q31 : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["CustomerConnectionString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;
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
                cmd = new SqlCommand("SELECT * FROM emp_info", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                gvEmployeeDetails.DataSource = dt;
                gvEmployeeDetails.DataBind();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
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
        protected void btnSearchSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSearch.Text != "" && Convert.ToInt32(TxtSearch.Text) > 0)
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "searchEmp";
                    cmd.Parameters.Add(new SqlParameter("@eid", SqlDbType.SmallInt)).Value =
                    Convert.ToInt16(TxtSearch.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lblMessage.Text = "Record found Successfully!";
                        while (dr.Read())
                        {
                            clearTextBox();
                            TxtEid.Text = dr["eid"].ToString();
                            TxtEName.Text = dr["ename"].ToString();
                            TxtEDesignation.Text = dr["designation"].ToString();
                            TxtESalary.Text = dr["salary"].ToString();
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Record not found!";
                    }
                }
                else
                {
                    lblMessage.Text = "Please enter roll number!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        protected void btnAddSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEid.Text != "" && TxtEName.Text != "" && TxtEDesignation.Text != "" && TxtESalary.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertEmp";
                    cmd.Parameters.Add(new SqlParameter("@eid", SqlDbType.SmallInt)).Value = Convert.ToInt16(TxtEid.Text);
                    cmd.Parameters.Add(new SqlParameter("@ename", SqlDbType.VarChar)).Value = TxtEName.Text;
                    cmd.Parameters.Add(new SqlParameter("@edesignation", SqlDbType.VarChar)).Value = TxtEDesignation.Text;
                    cmd.Parameters.Add(new SqlParameter("@esalary", SqlDbType.VarChar)).Value = TxtESalary.Text;
                    int r = cmd.ExecuteNonQuery();
                    if (r != 0)
                    {
                        lblMessage.Text = "Record inserted Successfully!";
                    }
                    else
                    {
                        lblMessage.Text = "Record not inserted!";
                    }
                }
                else
                {
                    lblMessage.Text = "Please enter all details!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception!" + ex.Message;
            }
            finally
            {
                conn.Close();
                clearTextBox();
                showData();
            }

        }
    }
}