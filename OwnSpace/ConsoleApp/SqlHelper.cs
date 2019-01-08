using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public static class SqlHelper
    {
        public static List<T> Query<T>(string query, object param = null)
        {
            using (var conn = ConfigUtils.GetTestConnection())
            {
                return conn.Query<T>(query, param).ToList();
            }
        }

        public static int Execute(string query, object param = null)
        {
            using (var conn = ConfigUtils.GetTestConnection())
            {
                return conn.Execute(query, param);
            }
        }
    }
}
