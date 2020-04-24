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
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Forum> Forum { get; set; }
        public DbSet<ForumsUserProfilesRelationship> ForumsUserProfilesRelationships { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().HasOne(c => c.User).WithOne(c => c.Profile);
            modelBuilder.Entity<Order>().HasOne(order => order.Executor).WithMany(profile => profile.ExecutorOnOrders).HasForeignKey(order => order.ExecutorId).HasPrincipalKey(profile => profile.Id);
            modelBuilder.Entity<Order>().HasOne(order => order.Customer).WithMany(profile => profile.CustomerOnOrders).HasForeignKey(order => order.CustomerId).HasPrincipalKey(profile => profile.Id);
            modelBuilder.Entity<ForumsUserProfilesRelationship>().HasKey(c => new { c.ForumId, c.UserProfileId });
            modelBuilder.Entity<ForumsUserProfilesRelationship>()
                .HasOne(FUp => FUp.UserProfile)
                .WithMany(Up => Up.Forums)
                .HasForeignKey(FUp => FUp.UserProfileId);
            modelBuilder.Entity<ForumsUserProfilesRelationship>()
                .HasOne(FUp => FUp.Forum)
                .WithMany(F => F.Users)
                .HasForeignKey(FUp => FUp.ForumId);

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          // Database.EnsureCreated();
        }
    }
}
