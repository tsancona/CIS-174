using FirstResponsiveWebAppAncona.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppAncona.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.CalculatedAgeMessage = "Please enter your name and birth year.";
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.CalculatedAgeMessage = $"Hello {model.Name}! You are {model.AgeThisYear()} this year.";
            }
            else
            {
                ViewBag.CalculatedAgeMessage = "Please enter your name and birth year.";
            }
            return View(model);
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