using Microsoft.Extensions.DependencyInjection;
using NT.Common;
using NT.ICommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.Web
{
    public static class Extension
    {
        public static void AddDbStoreHolder(this IServiceCollection service)
        {
            service.AddSingleton<IDbStoreHolder, DbStoreHolder>();
        }

    }
}
