using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurierLib.ViewModels;
using CurierLib.Repositories;
using CurierLib.Models;
using CurierLib.Services;

namespace Curier.Controllers
{
    public class OrderController : Controller
    {
        private readonly BaseRepository<Product> repositoryProduct;
        private readonly BaseRepository<Customer> repositoryCustomer;
        private readonly BaseRepository<Courier> repositoryCourier;
        private readonly OrderService orderService;

        public OrderController(BaseRepository<Product> repositoryProduct,
            BaseRepository<Customer> repositoryCustomer,
            BaseRepository<Courier> repositoryCourier, 
            OrderService orderService)
        {
            this.repositoryProduct = repositoryProduct;
            this.repositoryCustomer = repositoryCustomer;
            this.repositoryCourier = repositoryCourier;
            this.orderService = orderService;
        }



        // GET: OrderController
        public ActionResult Index()
        {
            var orders = orderService.GetOrdersList();
            return View(orders);

        }



      
        public ActionResult Create()
        {

            ViewData["Products"] = repositoryProduct.GetAllForRead().Select(x => new SelectDataListItem { Id = x.Id, Text = x.NameTovar }).ToList();
            ViewData["Courier"] = repositoryCourier.GetAllForRead().Select(x => new SelectDataListItem { Id = x.Id, Text = x.Name }).ToList();
            ViewData["Customer"] = repositoryCustomer.GetAllForRead().Select(x => new SelectDataListItem { Id = x.Id, Text = x.Name }).ToList();
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderToProductViewModel collection)
        {
            try
            {
                orderService.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["Products"] = repositoryProduct.GetAllForRead().Select(x => new SelectDataListItem { Id = x.Id, Text = x.NameTovar }).ToList();
                ViewData["Courier"] = repositoryCourier.GetAllForRead().Select(x => new SelectDataListItem { Id = x.Id, Text = x.Name }).ToList();
                ViewData["Customer"] = repositoryCustomer.GetAllForRead().Select(x => new SelectDataListItem { Id = x.Id, Text = x.Name }).ToList();
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
