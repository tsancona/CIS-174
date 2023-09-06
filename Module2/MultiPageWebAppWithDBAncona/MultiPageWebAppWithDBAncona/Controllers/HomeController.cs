/***************************************************************
* Name         : Multi-Page Web App w/ DB
* Author       : Tim Ancona
* Created      : 09/04/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This web app uses a database to maintain a list
*                   of contacts for the user.
*                      Input : contact information, add edit and
*                               delete requests
*                      Output: list of contacts
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
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