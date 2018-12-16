using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    [Authorize]
    public class StatusController : Controller
    {
        private readonly IRepository _repository;
        private readonly ILogger<StatusController> _logger;

        public StatusController(IRepository repository, ILogger<StatusController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET: Status
        public ActionResult Index()
        {
            return View(_repository.Statuses);
        }

        // GET: Status/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.GetStatus(id));
        }

        // GET: Status/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Status/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Status status)
        {
            try
            {
                _repository.Add(status);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return ErrorView(ex);
            }
        }

        // GET: Status/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View(_repository.GetStatus(id));
        }

        // POST: Status/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id, Status status)
        {
            try
            {
                _repository.Update(id, status);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return ErrorView(ex);
            }
        }

        // GET: Status/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View(_repository.GetStatus(id));
        }

        // POST: Status/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, Status status)
        {
            try
            {
                _repository.DeleteStatus(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return ErrorView(ex);
            }
        }

        private ActionResult ErrorView(Exception ex)
        {
            ModelState.AddModelError(string.Empty, "Unknown Error");
            _logger.LogError(ex, "Unknown Error");
            return View();
        }
    }
}