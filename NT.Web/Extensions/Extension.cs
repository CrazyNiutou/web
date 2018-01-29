using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
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
        public static IServiceCollection AddDbStoreHolder(this IServiceCollection service)
        {
            return service.AddSingleton<IDbStoreHolder, DbStoreHolder>();
        }
    }
}
