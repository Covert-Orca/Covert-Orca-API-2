﻿using System;
using Covert.Orca.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Covert.Orca.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            :base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}