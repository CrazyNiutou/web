using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using NT.IBusiness;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using NT.ICommon;

namespace NT.Web.Controllers
{
    public class AccountController : Controller
    {
        private IServiceProvider ProviderCase;
        public AccountController(IServiceProvider provider)
        {
            ProviderCase = provider;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [Route("account/login")]
        public Task<JsonResult> Login(string userName, string pwd, string returnUrl = null)
        {
            return null;
        }

    }
}