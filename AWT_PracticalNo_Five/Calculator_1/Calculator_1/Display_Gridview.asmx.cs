using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator_1
{
    /// <summary>
    /// Summary description for Display_Gridview
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Display_Gridview : System.Web.Services.WebService
    {
        static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(conStr);
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        [WebMethod]
        public DataTable DisplayAllRecord()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM emp_info", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable("emp");
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [WebMethod]
        public string insertRecord(int id, string ename, string esalary)
        {
            string msg;
            try
            {
                cmd = new SqlCommand("Insert into emp_info (eid, ename, esalary)VALUES(@id, @enm, @esal)", conn);
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@enm", ename);
                cmd.Parameters.AddWithValue("@esal", esalary);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    msg = "record inserted Successfully;";
                }
                else
                {
                    msg = "record not inserted";
                }
            }
            catch (Exception ex)
            { 
                msg = "Exception " + ex.Message; 
            }
            return msg;
        }

    }
}
