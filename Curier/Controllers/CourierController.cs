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
    public class CourierController : Controller
    {
        private readonly BaseRepository<Courier> repository;

        public CourierController(BaseRepository<Courier> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var models = repository.GetAllForRead();
            return View(models);
        }


        // GET: CourierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Courier model)
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

        // GET: CourierController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = repository.GetOne(id);
            return View(model);
        }

        // POST: CourierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Courier model)
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

        // GET: CourierController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = repository.GetOne(id);
            repository.Remove(model);
            return RedirectToAction(nameof(Index));
        }

    }
}
