﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsykShop.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AsykShop.Core
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Asyk> Asyk { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<AsykShopCartItem> AsykShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
