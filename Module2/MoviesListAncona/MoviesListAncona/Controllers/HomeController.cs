/***************************************************************
* Name         : EF Core Web App Lab
* Author       : Tim Ancona
* Created      : 09/03/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This is a web app with a database to store movies.
*                      Input : add, update, or delete movies
*                      Output: list of movies in the database
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using Microsoft.AspNetCore.Mvc;
using MoviesListAncona.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MoviesListAncona.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}