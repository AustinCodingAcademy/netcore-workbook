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
    public class CustomerController : Controller
    {
        
        private readonly IRepository _repository;
        public ApplicationContext Context { get; }

        public CustomerController(IRepository repository, ApplicationContext context)
        {
            Context = context;
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
            Context.Customers.Add(customer);
            Context.SaveChanges();
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