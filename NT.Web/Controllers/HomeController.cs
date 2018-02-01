using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NT.Models;
using NT.Web.Models;
using System;
using System.Diagnostics;

namespace NT.Web.Controllers
{
    public class HomeController : Controller
    {
        private MySqlOperator m_MySqlOperator;
        public HomeController(IServiceProvider provider)
        {
            m_MySqlOperator = provider.GetService<MySqlOperator>();
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
