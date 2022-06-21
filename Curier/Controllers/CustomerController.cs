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
    public class CustomerController : Controller
    {
        private readonly BaseRepository<Customer> repository;

        public CustomerController(BaseRepository<Customer> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var models = repository.GetAllForRead();
            return View(models);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer model)
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = repository.GetOne(id);
            return View(model);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer model)
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = repository.GetOne(id);
            repository.Remove(model);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
