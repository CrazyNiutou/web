using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.Web.Middleware.Platform
{
    public static class PlatformAuthenticationDefaults
    {
        public const string AuthenticationScheme = "myGirlsPlatform";

        public static readonly string PlatformPrefix = ".Platform.";

        public static readonly PathString LogoutPath = new PathString("/Account/Logout");

        public static readonly PathString AccessDeniedPath = new PathString("/Account/AccessDenied");

        public static readonly string ReturnUrlParameter = "ReturnUrl";
    }
}
