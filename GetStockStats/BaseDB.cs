using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GetStockStats
{
    public class BaseRepository
    {
        protected static IDbConnection OpenConnection(string dbName)
        {
            string conStr = GetConnectionString(dbName);
            var connection = new SqlConnection(conStr);
            connection.Open();

            return connection;
        }

        public static string GetConnectionString(string dbName)
        {
            var cfg = ConfigurationManager.ConnectionStrings["DBConnection"];
            return cfg.ConnectionString + dbName;
        }
    }
}
