using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace Calculator_1
{
    /// <summary>
    /// Summary description for Delete_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Delete_WebService : System.Web.Services.WebService
    {
        static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(conStr);
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        [WebMethod]
        public string DeleteRecord(int id, string name, string details, string price)
        {
            string msg;
            try
            {
                cmd = new SqlCommand("DELETE FROM product_info WHERE pid=@id",conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@details", details);
                cmd.Parameters.AddWithValue("@price", price);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    msg = "Record Delete Successfully ";
                }
                else
                {
                    msg = "Record Not Deleted ";
                }
            }
            catch (Exception ex)
            { msg = "Exception " + ex.Message; }
            return msg;
        }

        [WebMethod]
        public DataTable DisplayAllRecord()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM product_info", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable("product_info");
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
