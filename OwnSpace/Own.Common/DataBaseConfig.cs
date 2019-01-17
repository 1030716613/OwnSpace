using System.Configuration;
using System.Data.SqlClient;

namespace Own.Common
{
    public class DataBaseConfig
    {
        public static SqlConnection GetTestConnection()
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OwnTest"].ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
