using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day2.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day2.Controllers
{
    public class newController : Controller
    {



        public IActionResult Index()
        {
            var model = new Greeting2();
            model.FirstName = "Dylan";
            model.LastName = "Zocchi";
            return View(model); 

        }


    }


}
