using CurierLib.Models;
using CurierLib.Repositories;
using CurierLib.ViewModels;
using Scrutor.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Services
{
    public class OrderService : ISelfTransientLifetime
    {
        private readonly BaseRepository<Order> repositoryOrder;
        private readonly BaseRepository<Product> repositoryProduct;
        private readonly BaseRepository<Customer> repositoryCustomer;
        private readonly BaseRepository<Courier> repositoryCourier;
        private readonly BaseRepository<ProductToOrder> repositoryProductToOrder;

        public OrderService(BaseRepository<Order> repositoryOrder,
            BaseRepository<Product> repositoryProduct,
            BaseRepository<Customer> repositoryCustomer,
            BaseRepository<Courier> repositoryCourier, BaseRepository<ProductToOrder> repositoryProductToOrder)
        {
            this.repositoryOrder = repositoryOrder;
            this.repositoryProduct = repositoryProduct;
            this.repositoryCustomer = repositoryCustomer;
            this.repositoryCourier = repositoryCourier;
            this.repositoryProductToOrder = repositoryProductToOrder;
        }

        public void Create(OrderToProductViewModel model)
        {

            var productToOrder = repositoryProduct.GetAllForRead().Where(x => model.ProductIdsStrArray.Contains(x.Id));

            var order = repositoryOrder.Add(new Order
            {
                IdEmployer = model.IdEmployer,
                PriceOrder = productToOrder.Select(x=> x.PriceOne).Sum(),
                IdPokypatel =model.IdPokypatel,
                TimeOrder = model.TimeOrder
            });

            foreach(var productId in model.ProductIdsStrArray)
            {
                repositoryProductToOrder.Add(new ProductToOrder
                {
                    OrderId = order.Id,
                    ProductId = productId
                });
            }
        }

        public List<OrderToListViewModel> GetOrdersList()
        {
            var orders = repositoryOrder.GetAllForRead().ToList();

            var products = repositoryProduct.GetAllForRead().ToList();

            var returnedList = new List<OrderToListViewModel>();

            foreach(var order in orders)
            {
                var coirer = repositoryCourier.GetOne(order.IdEmployer);
                var pokupatel = repositoryCustomer.GetOne(order.IdPokypatel);
                var productToOrder = repositoryProductToOrder.GetAllForRead().Where(x => x.OrderId == order.Id).Select(x => x.ProductId).ToList();
                var productsOrders = repositoryProduct.GetAllForRead().Where(x => productToOrder.Contains(x.Id));

                returnedList.Add(new OrderToListViewModel
                {
                    Coirer = coirer?.Name + " " + coirer?.Surname,
                    Customer = pokupatel?.Name,
                    Tovar = string.Join(" ",productsOrders.Select(x => x.NameTovar)),
                    Price = order.PriceOrder.ToString() + ".р",
                    Data = order.TimeOrder
                });
            }


            return returnedList;
        }
    }
}
