using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            ViewBag.AccessLevel = ControllerContext.RouteData.Values["id"] is not null ? ControllerContext.RouteData.Values["id"]!.ToString() : "1";
            if (int.TryParse(ViewBag.AccessLevel, out int accessLevel))
            {
                if (accessLevel < 1 || accessLevel > 10)
                {
                    ViewBag.AccessLevel = 1;
                }
                else
                {
                    ViewBag.AccessLevel = accessLevel;
                }

            }
            else
            {
                ViewBag.AccessLevel = 1;
            }

            ViewBag.Students = new List<StudentModel>
            {
                new StudentModel
                {
                    FirstName = "Pike",
                    LastName = "Myers",
                    Grade = "C"
                },
                new StudentModel
                {
                    FirstName = "Cod",
                    LastName = "Rundgren",
                    Grade = "D"
                },
                new StudentModel
                {
                    FirstName = "Halibut",
                    LastName = "Berry",
                    Grade = "B"
                },
                new StudentModel
                {
                    FirstName = "Jackson",
                    LastName = "Pollock",
                    Grade = "B"
                },
                new StudentModel
                {
                    FirstName = "Shark",
                    LastName = "Twain",
                    Grade = "A"
                }
            };

            return View();
        }
    }
}
