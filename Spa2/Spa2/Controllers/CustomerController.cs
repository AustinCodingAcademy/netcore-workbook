using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spa2.Models;

namespace Spa2.Controllers
{
    public class CustomerController : Controller
    {
        
        private readonly IRepository _repository;

        public CustomerController(IRepository repository)
        {
            _repository = repository;
        }
        
        public IActionResult Index()
        {
            return View(_repository.Customers);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Customer customer)
        {
            _repository.AddCustomer(customer);
            return View("Index", _repository.Customers);
        }

        public IActionResult Delete(Customer customer)
        {
            var item = _repository.Customers.Single(r => r.Id == customer.Id);
            _repository.RemoveCustomer(item);
            return View("Index", _repository.Customers);
        }
    }
}