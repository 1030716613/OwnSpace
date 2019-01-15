using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
