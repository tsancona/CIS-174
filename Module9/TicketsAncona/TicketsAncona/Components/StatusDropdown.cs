using Microsoft.AspNetCore.Mvc;
using TicketsAncona.Models;

namespace TicketsAncona.Components
{
    public class StatusDropdown : ViewComponent
    {
        public IViewComponentResult Invoke(TicketViewModel model)
        {
            return View("~/Views/Shared/_StatusDropdownPartial.cshtml", model);
        }
    }
}
