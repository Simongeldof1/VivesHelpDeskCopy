using Microsoft.AspNetCore.Mvc;
using VivesHelpdesk.Ui.WebApp.Data;

namespace VivesHelpdesk.Ui.WebApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly VivesHelpdeskDatabase _database;

        public TicketController(VivesHelpdeskDatabase database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            var tickets = _database.Tickets;
            return View(tickets);
        }
    }
}
