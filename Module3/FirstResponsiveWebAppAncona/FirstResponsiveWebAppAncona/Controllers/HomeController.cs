/***************************************************************
* Name         : WebApp with Unit Tests
* Author       : Tim Ancona
* Created      : 09/11/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : Web app that takes a user's name and birth year,
*				 then outputs their age.
*                      Input : name, birth year
*                      Output: age, passing unit tests
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using FirstResponsiveWebAppAncona.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppAncona.Controllers
{
    public class HomeController : Controller
    {
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