using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace NT.ICommon
{
    public interface IDbStoreHolder
    {
        string MySqlConnectString { get; set; }

    }
}
