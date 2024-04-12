using Assignments.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignments.Controllers
{
    public class HomeController : Controller
    {
        ShopBIuContext Db = new ShopBIuContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var product = Db.TbProducts.ToList();
            return View(product);
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Details()
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
    }
}
