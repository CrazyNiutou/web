using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.Web
{
    public class PlatformAuthenticationOption : AuthenticationOptions, IOptions<PlatformAuthenticationOption>
    {
        public PlatformAuthenticationOption Value => throw new NotImplementedException();
    }
}
