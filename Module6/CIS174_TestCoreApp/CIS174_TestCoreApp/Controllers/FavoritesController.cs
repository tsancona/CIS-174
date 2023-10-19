/***************************************************************
* Name         : Website Add Adding Session State
* Author       : Tim Ancona
* Created      : 10/17/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This web app demonstrates the usage of session
*                state by adding the ability to favorite teams.
*                      Input : favorite teams
*                      Output: favorites list
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174_TestCoreApp.Controllers
{
    public class FavoritesController : Controller
    {
        private OlympicTeamContext context;
        public FavoritesController(OlympicTeamContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new OlympicTeamsViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat(),
                OlympicTeams = session.GetMyTeams()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(OlympicTeamsViewModel model)
        {
            model.OlympicTeam = context.OlympicTeams.Include(t => t.OlympicGame).Include(t => t.OlympicCategory).Where(t => t.OlympicTeamID == model.OlympicTeam.OlympicTeamID).FirstOrDefault() ?? new OlympicTeam();
            var session = new OlympicSession(HttpContext.Session);
            var teams = session.GetMyTeams();
            teams.Add(model.OlympicTeam);
            session.SetMyTeams(teams);

            TempData["message"] = $"{model.OlympicTeam.Name} added to your favorites";
            return RedirectToAction("Index", "Olympic",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            session.RemoveMyTeams();

            TempData["message"] = "Favorite teams cleared";
            return RedirectToAction("Index", "Olympic",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }
    }
}
