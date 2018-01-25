using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace NT.Standard
{
    public class DbStoreHolder
    {
        public static readonly string WebDbConnectionString;
        public static readonly IDbConnection WebDbConnection = new MySqlConnection();
    }
}