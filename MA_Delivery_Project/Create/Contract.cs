using MA_Delivery_Project.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MA_Delivery_Project.Create
{
    public class Contract
    {
        // get connection
        public static string AddContractDetails(Contract cont , string con, string qry )
        {//
            string conStr = con;
            SqlConnection Sql = new SqlConnection(conStr);
            Sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Sql;
            cmd.CommandText = qry;
            var data = cmd.ExecuteScalar();
            Sql.Close();
            data = data != null ? data : "";
            return data.ToString();

        }
        public static string  UpdateContactdetails(Contract cont, string con, string qry)
        {//
            string conStr = con;
            SqlConnection Sql = new SqlConnection(conStr);
            Sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Sql;
            cmd.CommandText = qry;
            var data = cmd.ExecuteScalar();
            Sql.Close();
            data = data != null ? data : "";
            return data.ToString();
        }
        public static string Delete(Contract cont, string con, string qry)
        {
            string conStr = con;
            SqlConnection Sql = new SqlConnection(conStr);
            Sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Sql;
            cmd.CommandText = qry;
           // var data = "";
            var data = cmd.ExecuteScalar();
           
            Sql.Close();
            data = data != null ? data : "";
            return data.ToString();
        }
    }
}

