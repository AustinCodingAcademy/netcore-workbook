using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Spa2.Models;
using Spa2.Data;

namespace Spa2.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IRepository _repository;
        public ApplicationContext _context { get; }


        public AppointmentController(IRepository repository, ApplicationContext context)
        {
            _context = context;
            _repository = repository;

        }

        public IActionResult Index()
        {
            return View(_context.Appointments);
        }

        [HttpGet]
        public IActionResult Create(Customer customer, ServiceProvider serviceProvider)
        {
            List<Customer> NewCustomers = new List<Customer>();
            foreach (var c in _context.Customers)
            {
                NewCustomers.Add(c);
            }
            ViewData["NewCustomers"] = NewCustomers;
        
            List<ServiceProvider> NewServiceProviders = new List<ServiceProvider>();
            foreach (var item in _context.ServiceProviders)
            {
                NewServiceProviders.Add(item);
            }
            ViewData["NewServiceProviders"] = NewServiceProviders;
            return View();
        }

        public IActionResult ProviderIndex(Appointment appointment)
        {            
            List<Appointment> ProviderAppointments = new List<Appointment>();
            foreach (var item in _context.Appointments)
            {
                ProviderAppointments.Add(item);
            }
            ViewData["ProviderAppointments"] = ProviderAppointments;
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            try
            {
                _repository.BookAppointment(appointment, _context);
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
                return View("Index", _context.Appointments);
            }
            catch
            {
                ViewBag.message = "Please select a new appointment";
                return View("Index", _context.Appointments);
            }            
        }

        public async Task<IActionResult> Delete(Appointment appointment)
        {
            //var item = _repository.Appointments.Single(r => r.AppointmentId == appointment.AppointmentId);
            //_repository.RemoveAppointment(item);
            var a = await _context.Appointments.FindAsync(appointment.AppointmentId);
            _context.Appointments.Remove(a);
            await _context.SaveChangesAsync();
            return View("Index", _context.Appointments);
        }
    }
}