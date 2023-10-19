/***************************************************************
* Name         : Data Transfer - Olympic Teams assignment
* Author       : Tim Ancona
* Created      : 10/11/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This web app demonstrates the transferring of
*                data between controllers and views
*                      Input : selection of olympic game and 
*                              category
*                      Output: different views based on game
*                              category selected, details page
*                              when flag is clicked
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
    public class OlympicController : Controller
    {
        private OlympicTeamContext context;

        public OlympicController(OlympicTeamContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(OlympicTeamsViewModel model)
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(model.ActiveGame);
            session.SetActiveCat(model.ActiveCat);
            model.OlympicGames = context.OlympicGames.ToList();
            model.OlympicCategories = context.OlympicCategories.ToList();

            IQueryable<OlympicTeam> query = context.OlympicTeams.OrderBy(t => t.Name);
            if (model.ActiveGame != "all")
            {
                query = query.Where(t => t.OlympicGame.OlympicGameID.ToLower() == model.ActiveGame.ToLower());
            }
            if (model.ActiveCat != "all")
            {
                query = query.Where(t => t.OlympicCategory.OlympicCategoryID.ToLower() == model.ActiveCat.ToLower());
            }

            model.OlympicTeams = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new OlympicTeamsViewModel
            {
                OlympicTeam = context.OlympicTeams.Include(t => t.OlympicGame).Include(t => t.OlympicCategory).FirstOrDefault(t => t.OlympicTeamID == id) ?? new OlympicTeam(),
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat()
            };
            
            return View(model);
        }
    }
}
