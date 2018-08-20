using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA.Data;
using SPA.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SPA.Controllers
{
    public class SpaController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [Route("Create")]
        [HttpGet]

        public IActionResult Create()
        {

            var name = new Customer
            {
                _firstName = "",
                _lastName = "" 
            };
            return View(name);
        }


        [Route("Create")]
        [HttpPost]

        public IActionResult Create(Customer name)
        {
            
            Console.WriteLine(name._firstName);
            Console.WriteLine(name.LastName);
            return Redirect(nameof(Create));
        }

        public IActionResult Remove()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
