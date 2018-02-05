using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.Web
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UserPlatformAuthentication(this IApplicationBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));
            return app.UseMiddleware<PlatformAuthenticationMiddleware>();
        }
        //public static IApplicationBuilder UserPlatformAuthentication(this IApplicationBuilder app,)
    }
}
