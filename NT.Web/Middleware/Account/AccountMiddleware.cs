using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.Web
{
    public class AccountMiddleware
    {
        private readonly RequestDelegate _next;
        public AccountMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.WriteAsync("测试");
            return this._next(context);
        }
    }
}
