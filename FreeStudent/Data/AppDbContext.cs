using FreeStudent.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().HasOne(c => c.User).WithOne(c => c.Profile);
            modelBuilder.Entity<Order>().HasOne(order => order.Executor).WithMany(profile => profile.ExecutorOnOrders).HasForeignKey(order => order.ExecutorId).HasPrincipalKey(profile => profile.Id);
            modelBuilder.Entity<Order>().HasOne(order => order.Customer).WithMany(profile => profile.CustomerOnOrders).HasForeignKey(order => order.CustomerId).HasPrincipalKey(profile => profile.Id);

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          //  Database.EnsureCreated();
        }
    }
}
