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

       
        [HttpGet]

        public IActionResult CustomerInfo()
        {

            var name = new Customer
            {

                Id = 1,
                _firstName = "",
                _lastName = "" 
            };
            return View(name);
        }



        [HttpPost]

        public IActionResult CustomerInfo(Customer name)
        {
            
            Console.WriteLine(name._firstName);
            Console.WriteLine(name._lastName);
            Console.WriteLine(name.Id);
            return Redirect(nameof(CustomerInfo));
        }

        public IActionResult Remove()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Appointments()
        {
            var time = new Apts
            {

                Id = 1,
                JoinDate = new DateTime(int year, int month, int day)
                
            };
            return View(time);

            
        }
        [HttpPost]
        public IActionResult Appointments()
        {

            Console.WriteLine()
            return View();
        }
    }
}
