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
        public async Task<JsonResult> Login(string userName, string pwd, string returnUrl = null)
        {
            var outParam = ProviderCase.GetService<OutputParam>();
            var json = string.Empty;
            try
            {
                var business = ProviderCase.GetService<IAccount>();
                var list = await business.GetUsersInfo(userName, pwd);
                var userInfo = list.FirstOrDefault();
                var claimIdentity = new ClaimsIdentity("Cookie");
                claimIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userInfo.UserID));
                claimIdentity.AddClaim(new Claim(ClaimTypes.Name, userInfo.UserName));
                claimIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userInfo.UserID));
                claimIdentity.AddClaim(new Claim(ClaimTypes.Name, userInfo.UserName));

                var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                await HttpContext.SignInAsync("MyCookieMiddleware", claimPrincipal, new AuthenticationProperties() { ExpiresUtc = DateTime.UtcNow.AddMinutes(60) });

                outParam.ReturlUrl = string.IsNullOrWhiteSpace(returnUrl) ? "/home/index" : returnUrl;
                json = JsonConvert.SerializeObject(outParam);

            }
            catch (Exception ex)
            {
                outParam.StatusCode = 999;
                outParam.ErrMsg = "调用登录接口失败";
            }
            await Task.Delay(0);
            return new JsonResult(json);
        }

    }
}