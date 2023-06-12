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
    /// Summary description for Update_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Update_WebService : System.Web.Services.WebService
    {
        static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(conStr);
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;
        [WebMethod]
        public string UpdateProduct(int id, string name, string details, string price)
        {
            string msg;
            try
            {
                cmd = new SqlCommand("Update product_info SET pname = @nm, pdetails = @details, price = @cost where pid = @id", conn);
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@details", details);
                cmd.Parameters.AddWithValue("@cost", price);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    msg = "record Update Successfully;";
                }
                else
                {
                    msg = "record notUpdate";
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
