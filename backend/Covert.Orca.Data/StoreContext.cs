using System;
using Covert.Orca.Domain.Catalog;
using Covert.Orca.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Covert.Orca.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            :base(options)
        { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
