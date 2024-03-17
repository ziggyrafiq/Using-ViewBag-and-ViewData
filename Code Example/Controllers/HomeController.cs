using Code_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Code_Example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "I am Ziggy Rafiq";
            ViewData["Message"] = "This is Ziggy Rafiq Blog Site";
            return View();
        }
        public ActionResult GetData(string myData)
        {
            return Content(myData);
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