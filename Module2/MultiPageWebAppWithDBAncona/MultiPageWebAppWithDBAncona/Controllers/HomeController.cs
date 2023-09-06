using Microsoft.AspNetCore.Mvc;
using MultiPageWebAppWithDBAncona.Models;
using System.Diagnostics;

namespace MultiPageWebAppWithDBAncona.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ContactContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, ContactContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.ContactId).ToList();
            return View(contacts);
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