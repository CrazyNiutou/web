using Microsoft.Extensions.Options;
using NT.ICommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace NT.Common
{
    public class DbStoreHolder : IDbStoreHolder
    {
        public string MySqlConnectString { get; set; }
        private readonly IOptions<ConfigOptions> _Options;
        public DbStoreHolder(IOptions<ConfigOptions> options)
        {
            _Options = options;
            MySqlConnectString = _Options.Value.ConnectString;
        }

    }
}