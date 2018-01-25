using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NT.Models.Db.Operator
{
    public class DbCommonHolder
    {
        public static readonly string ConnectString;
        public static readonly MySqlConnection mySqlConnection=new MySqlConnection();
        public static IDbConnection GetMySqlDbConnection(string connectionString)
        {
            return new MySqlConnection(connectionString);
        }
    }
}
