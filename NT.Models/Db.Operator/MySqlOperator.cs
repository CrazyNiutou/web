using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using NT.ICommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NT.Models
{
    public class MySqlOperator
    {
        private IDbStoreHolder m_dbStoreHolder;

        private MySqlConnection DbConnect;
        public MySqlOperator(IDbStoreHolder dbStoreHolder)
        {
            m_dbStoreHolder = dbStoreHolder;
            DbConnect = new MySqlConnection(m_dbStoreHolder.MySqlConnectString);
        }
        public MySqlConnection GetMySqlDbConnection()
        {
            return DbConnect;
        }
    }
}
