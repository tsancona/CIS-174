﻿/***************************************************************
* Name         : Tickets App
* Author       : Tim Ancona
* Created      : 10/25/2023
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This app demonstrates model binding through a
*                ticketing app for tracking projects.
*                      Input : Ticket info
*                      Output: Tickets
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TicketsAncona.Models;

namespace TicketsAncona.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TicketContext context;

        public HomeController(ILogger<HomeController> logger, TicketContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index(string id)
        {
            var model = new TicketViewModel
            {
                Filters = new Filters(id),
                Statuses = context.Statuses.ToList()
            };

            IQueryable<Ticket> query = context.Tickets.Include(t => t.Status);

            if (model.Filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == model.Filters.StatusId);
            }
            model.Tickets = query.OrderBy(t => t.SprintNumber).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new TicketViewModel
            {
                Statuses = context.Statuses.ToList(),
                CurrentTicket = new Ticket { StatusId = "toDo" }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Tickets.Add(model.CurrentTicket);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "There are errors in the form.");
                model.Statuses = context.Statuses.ToList();
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Filter(string filter)
        {
            string id = filter;
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult MarkComplete([FromRoute] string id, Ticket selected)
        {
            selected = context.Tickets.Find(selected.Id)!;
            if (selected != null)
            {
                selected.StatusId = "done";
                context.SaveChanges();
            }

            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id)
        {
            var toDelete = context.Tickets.Where(t => t.StatusId == "done").ToList();

            foreach (var ticket in toDelete)
            {
                context.Tickets.Remove(ticket);
            }

            context.SaveChanges();
            return RedirectToAction("Index", new { ID = id });
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