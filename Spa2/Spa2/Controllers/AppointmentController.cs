using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spa2.Models;

namespace Spa2.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IRepository _repository;
        public AppointmentController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.Appointments);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            try
            {
                _repository.BookAppointment(appointment);
                return View("Index", _repository.Appointments);

            }
            catch
            {
                ViewBag.message = "Please select a new appointment";
                return View("Index", _repository.Appointments);
            }
            
           

            

            


        }
 
        public IActionResult Delete(Appointment appointment)
        {
            
            var item = _repository.Appointments.Single(r => r.Id == appointment.Id);          
            _repository.RemoveAppointment(item);

 

            return View("Index", _repository.Appointments);
        }
    }
}