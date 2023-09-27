using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppAncona.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticContent(string num)
        {
            if (int.TryParse(num, out int id))
            {
                ViewBag.Num = id;
            }
            else
            {
                ViewBag.Num = 0;
            }
            return View();
        }

        [Route("attr-routing")]
        public IActionResult AttributeRouting()
        {
            return View();
        }
    }
}
