using CurierLib.Models;
using CurierLib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curier.Controllers
{
    public class ProductController : Controller
    {
        private readonly BaseRepository<Product> repository;

        public ProductController(BaseRepository<Product> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var models = repository.GetAllForRead(); 
            return View(models);
        }

        // GET: TovarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TovarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TovarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {
            try
            {
                repository.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: TovarController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = repository.GetOne(id);
            return View(model);
        }

        // POST: TovarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product model)
        {
            try
            {
                repository.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: TovarController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = repository.GetOne(id);
            repository.Remove(model);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
