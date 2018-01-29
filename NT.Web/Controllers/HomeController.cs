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
using NT.Models;
using NT.Web.Models;
using Dapper;

namespace NT.Web.Controllers
{
    public class HomeController : Controller
    {
        public ConfigOptions config;
        private MySqlOperator m_MySqlOperator;
        public HomeController(IServiceProvider provider)
        {
            m_MySqlOperator = provider.GetService<MySqlOperator>();
        }
        public IActionResult Index()
        {
            using (var connect = m_MySqlOperator.GetDbConnection())
            {
                var test = connect.Query("select * from t_user");
            }
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
