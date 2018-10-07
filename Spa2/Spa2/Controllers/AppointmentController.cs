using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Spa2.Models;
using Spa2.Data;
using Microsoft.EntityFrameworkCore;

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
        
        public async Task<IActionResult> Index()
        {
            ViewBag.Customers =  await _context.Customers.ToListAsync();
            ViewBag.ServiceProviders =  await _context.ServiceProviders.ToListAsync();
            return View(await _context.Appointments.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
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
 
        [HttpPost]       
        public async Task<IActionResult> Create(Appointment appointment)
        {
            try
            {
                _repository.BookAppointment(appointment, _context);
                _context.Appointments.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.message = "Please select a new appointment";
                return View("Index", _context.Appointments);
            }             
        }

        public async Task<IActionResult> Delete(Appointment appointment)
        {
            var a = await _context.Appointments.FindAsync(appointment.AppointmentId);
            _context.Appointments.Remove(a);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}