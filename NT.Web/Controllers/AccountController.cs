using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NT.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [Route("account/login")]
        public JsonResult Login(string userName, string pwd)
        {
            var test = "123";
            var test1 = JsonConvert.SerializeObject(test);
            return new JsonResult(test1);
        }

    }
}