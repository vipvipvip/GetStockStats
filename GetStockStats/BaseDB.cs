using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GetStockStats
{
    public class BaseRepository
        {
            protected static IDbConnection OpenConnection(string dbName)
            {
                var cfg = ConfigurationManager.ConnectionStrings["DBConnection"];
                var connection = new SqlConnection(cfg.ConnectionString);
                connection.ConnectionString = cfg.ConnectionString + dbName;
                connection.Open();

                return connection;
            }
        }

}
