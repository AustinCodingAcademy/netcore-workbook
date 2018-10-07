﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalApp.Data;
using FinalApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalApp.Controllers
{
    public class ProductController : Controller
    {
        public ApplicationContext _context { get; set; }
        public ProductController(ApplicationContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.AsNoTracking().ToListAsync());
        }
      
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            try
            {
                 _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(Product product)
        {
            var c = await _context.Products.FindAsync(product.ProductId);
            _context.Products.Remove(c);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", _context.Products);
        }

        public ActionResult Edit(Product product)
        {
            return RedirectToAction("Index", _context.Products);

        }

    }
}