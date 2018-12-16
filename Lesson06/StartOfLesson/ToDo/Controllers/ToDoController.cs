using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ToDoApp.Areas.Tags.Data;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IRepository _repository;
        private readonly TagContext tagContext;
        private readonly ILogger<ToDoController> _logger;

        public ToDoController(IRepository repository, TagContext tagContext, ILogger<ToDoController> logger)
        {
            _repository = repository;
            this.tagContext = tagContext;
            _logger = logger;
        }

        // GET: ToDo
        public ActionResult Index()
        {
            return View(_repository.ToDos.Include(x => x.Status));
        }

        // GET: ToDo/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.GetToDo(id));
        }

        // GET: ToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDo toDo)
        {
            try
            {
                toDo.Tags = tagContext.Tags.ToList();
                _repository.Add(toDo);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return ErrorView(ex);
            }
        }

        // GET: ToDo/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.GetToDo(id));
        }

        // POST: ToDo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ToDo toDo)
        {
            try
            {
                _repository.Update(id, toDo);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return ErrorView(ex);
            }
        }

        // GET: ToDo/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repository.GetToDo(id));
        }

        // POST: ToDo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ToDo collection)
        {
            try
            {
                _repository.DeleteToDo(id);
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