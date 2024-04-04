using System.Data.SqlClient;
using MVCWebApp.Models;

namespace MVCWebApp.Data
{
    public class Database
    {
        //public static string _connectionString = "Data Source=localhost;Initial Catalog=masterhomelessdb;Integrated Security=True";
        public static string _connectionString = "Data Source=localhost;Initial Catalog=app_db;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

    }
}
