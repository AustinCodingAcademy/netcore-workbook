using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    public class StatusController : Controller
    {
        public List<Models.Status> statusList = new List<Models.Status>()
        {
            new Models.Status{ Id = 4, Value = "idk why im doing this"},
            new Models.Status{ Id = 5, Value = "this seems weird to do it this way"},
            new Models.Status{ Id = 6, Value = "what is life even"},
        };
        public IActionResult Index()
        {
            return View(statusList);
        }
    }
}