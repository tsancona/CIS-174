/***************************************************************
* Name         : Creating Razor Templates
* Author       : Tim Ancona
* Created      : 10/03/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This web app demonstrates the use of several
*                Razor View features, including layouts, templates
*                partial views, loops, and conditionals
*                      Input : access level
*                      Output: different views based on access
*                              levels 1, 2-7, and 8-10. Anything
*                              entered as an access level aside from
*                              numbers 1-10 will default to a 1.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS174_TestCoreApp.Controllers
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