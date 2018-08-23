using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spa2.Models;

namespace Spa2.Controllers
{
    public class ServiceProviderController : Controller
    {
        private readonly IRepository _repository;
        public ServiceProviderController(IRepository repository)
        {
            _repository = repository;
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