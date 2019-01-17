using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Own.Common
{
    public static class SqlHelper
    {
        public static List<T> Query<T>(string query, object param = null)
        {
            using (var conn = DataBaseConfig.GetTestConnection())
            {
                return conn.Query<T>(query, param).ToList();
            }
        }

        public static int Execute(string query, object param = null)
        {
            using (var conn = DataBaseConfig.GetTestConnection())
            {
                return conn.Execute(query, param);
            }
        }
    }
}
