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
        public ApplicationContext _context { get; }

        public ServiceProviderController(IRepository repository, ApplicationContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ServiceProviders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServiceProvider serviceProvider)
        {
            _context.ServiceProviders.Add(serviceProvider);
            await _context.SaveChangesAsync();
            return View("Index", _context.ServiceProviders);
        }

        public async Task<IActionResult> Delete(ServiceProvider serviceProvider)
        {
            var s = await _context.ServiceProviders.FindAsync(serviceProvider.ServiceProviderId);
            _context.ServiceProviders.Remove(s);
            await _context.SaveChangesAsync();
            return View("Index", _context.ServiceProviders);
        }
    }
}