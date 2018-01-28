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
        public string WebDbConnectionString;
        public DbStoreHolder(IOptions<ConfigOptions> options)
        {

        }
    }
}