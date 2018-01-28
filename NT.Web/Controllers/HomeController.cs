using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NT.Common;
using NT.ICommon;
using NT.Web.Models;

namespace NT.Web.Controllers
{
    public class HomeController : Controller
    {
        public ConfigOptions config;
        public HomeController(IOptions<ConfigOptions> options)
        {
            var service = new ServiceCollection();
            var provider = service.BuildServiceProvider();
            var test = provider.GetService<DbStoreHolder>();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
