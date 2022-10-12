﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VivesHelpdesk.Ui.WebApp.Data;
using VivesHelpdesk.Ui.WebApp.Models;

namespace VivesHelpdesk.Ui.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VivesHelpdeskDatabase _database;

        public HomeController(
            ILogger<HomeController> logger, 
            VivesHelpdeskDatabase database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult Index()
        {
            var tickets = _database.Tickets;
            return View(tickets);
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

