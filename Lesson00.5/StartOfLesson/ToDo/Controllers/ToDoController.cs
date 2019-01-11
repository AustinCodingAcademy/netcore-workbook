using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {

        public List<Models.ToDo> listOfTodo = new List<Models.ToDo>()
        {
            new Models.ToDo{ Id = 1, Description = "Do a thing", Status = new Status() { Id = 1, Value = "Done" } },
            new Models.ToDo{ Id = 2, Description = "Do another thing", Status = new Status() { Id = 2, Value = "Pending" }  },
            new Models.ToDo{ Id = 3, Description = "Don't do nothin'", Status = new Status() { Id = 3, Value = "Not Done" }  },
        };
        public IActionResult Index()
        {
            return View(listOfTodo);
        }
    }
}