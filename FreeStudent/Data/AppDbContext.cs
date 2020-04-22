using FreeStudent.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeStudent.Data.Models.Relationships;

namespace FreeStudent.Data
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        //public DbSet<OrderCustomerRelation> OrderCustomerRelations { get; set; }
        //public DbSet<OrderExecutorRelation> OrderExecutorRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().HasMany(userProfile => userProfile.IsExecutorInOrders).WithOne(order => order.Executor).HasForeignKey(order => order.Executor).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserProfile>().HasMany(userProfile => userProfile.IsCustomerInOrders).WithOne(order => order.Customer).HasForeignKey(order => order.Customer).OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          //  Database.EnsureCreated();
        }
    }
}
