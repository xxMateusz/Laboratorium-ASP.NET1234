using Laboratorium1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium1.Controllers
{
    public enum Operator
    {
        Add, Sub, Mul, Div, Unknown
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "calc-op")] Operator op, double? a, double? b)
        {
            ViewBag.op = op;
            ViewBag.a = a;
            ViewBag.b = b;

            double? result = 0;

            switch (op)
            {
                case Operator.Add:
                    result = a + b;
                    break;
                case Operator.Sub:
                    result = a - b;
                    break;
                case Operator.Mul:
                    result = a * b;
                    break;
                case Operator.Div:
                    result = a / b;
                    break;
            }

            ViewBag.result = result;
            return View();
        }
    }
}