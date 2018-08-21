using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spa2.Models;

namespace Spa2.Controllers
{
    public class SpaController : Controller
    {
        [HttpGet]
        public IActionResult CustomerName()
        {
            
            var name = new Customer
            {
                Id = 1,
                name = ""

            };
            return View();

            List<string> customers = new List<string>();

            foreach (string whatever in customers)
            {
                customers.Add(whatever);
            }




        }
        [HttpPost]

        public IActionResult CustomerName(Customer name)
        {
            Console.WriteLine(name.Id);
            Console.WriteLine(name.name);

            
            return Redirect(nameof(CustomerName));
        }

        [HttpGet]
        public IActionResult AptView()
        {
            var time = new Appointment()
            {
                AptTime = ""
                //Date = 

            };
            return View();
               
        }

        [HttpPost]
        public IActionResult AptView(Appointment time)
        {
            Console.WriteLine(time.AptTime);
            //Console.WriteLine(Date);
        
            return Redirect(nameof(AptView));
        }

        [HttpGet]
        public IActionResult Services()
        {
            var serviceprovider = new ServiceProvider()
            {
               serviceprovider = ""

            };
            return View();

        }

        [HttpPost]
        public IActionResult Services(ServiceProvider service)
        {
            Console.WriteLine(service.serviceprovider);
            //Console.WriteLine(Date);

            return Redirect(nameof(Services));
        }
    }
}