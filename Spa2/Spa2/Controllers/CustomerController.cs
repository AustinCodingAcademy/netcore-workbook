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
    public class CustomerController : Controller
    {
        
        private readonly IRepository _repository;
        public ApplicationContext _context { get; }

        public CustomerController(IRepository repository, ApplicationContext context)
        {           
            _repository = repository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.AsNoTracking().ToListAsync());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return View("Index", _context.Customers);
        }

        public async Task<IActionResult> Delete(Customer customer)
        {
            var c = await _context.Customers.FindAsync(customer.CustomerId);
            _context.Customers.Remove(c);
            await _context.SaveChangesAsync();
            return View("Index", _context.Customers);
        }
    }
}