using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ConfigUtils
    {
        public static SqlConnection GetTestConnection()
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OwnTest"].ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
