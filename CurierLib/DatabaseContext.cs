using CurierLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurierLib
{
    public class DatabaseContext : DbContext
    { 
        /// <summary>
        ///  Таблицы заказов
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Таблица Товаров
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Таблица Курьеров
        /// </summary>
        public DbSet<Courier> Couriers { get; set; }

        /// <summary>
        /// Таблица Заказчиков
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        public DbSet<ProductToOrder> ProductToOrders { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
          
    }
}
