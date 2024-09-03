using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetApiWithAuthentication.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(): base("db") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasRequired(x => x.OrderMaster)
                .WithMany(x => x.OrderDetail)
                .HasForeignKey(x => x.OrderId);
        }
    }
}