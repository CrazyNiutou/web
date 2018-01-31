using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NT.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("account/login"), HttpPost]
        public string Login(string userName, string pwd)
        {
            return "测试";
        }

        [Route("account/register"), HttpPost]
        public IActionResult Register()
        {
            return View();
        }
    }
}