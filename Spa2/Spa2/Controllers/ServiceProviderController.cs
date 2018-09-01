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
    public class ServiceProviderController : Controller
    {
        private readonly IRepository _repository;
        public ApplicationContext Context { get; }

        public ServiceProviderController(IRepository repository, ApplicationContext context)
        {
            _repository = repository;
            Context = context;

        }

        public IActionResult Index()
        {
            return View(_repository.ServiceProviders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ServiceProvider serviceProvider)
        {
            _repository.AddServiceProvider(serviceProvider);
            Context.ServiceProviders.Add(serviceProvider);
            Context.SaveChanges();
            return View("Index", _repository.ServiceProviders);
        }

        public IActionResult Delete(ServiceProvider serviceProvider)
        {
            var item = _repository.ServiceProviders.Single(r => r.Id == serviceProvider.Id);
            _repository.RemoveServiceProvider(item);
            return View("Index", _repository.ServiceProviders);
        }
    }
}