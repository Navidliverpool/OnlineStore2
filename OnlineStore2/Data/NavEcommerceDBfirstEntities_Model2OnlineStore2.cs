using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore2.Models;
using OnlineStore2_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineStore2.Data
{
    public class NavEcommerceDBfirstEntities_Model2OnlineStore2 : IdentityDbContext
    {
        public NavEcommerceDBfirstEntities_Model2OnlineStore2(DbContextOptions<NavEcommerceDBfirstEntities_Model2OnlineStore2> options)
            : base(options)
        {
        }
        // DbSet for each of your entity classes
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Motorcycle>()
               .HasMany(m => m.Dealers)
               .WithMany(d => d.Motorcycles)
               .UsingEntity(a => a.ToTable("MotorcycleDealers"));

            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Categories)
                .WithMany(c => c.Brands)
               .UsingEntity(a => a.ToTable("BrandCategories"));

            modelBuilder.Entity<Brand>()
            .HasMany(b => b.Dealers)
            .WithMany(d => d.Brands)
            .UsingEntity(a => a.ToTable("BrandDealers"));


            modelBuilder.Entity<Motorcycle>()
           .HasOne(m => m.Brand)
           .WithMany(b => b.Motorcycles)
           .HasForeignKey(m => m.BrandId);

            modelBuilder.Entity<Motorcycle>()
           .HasOne(m => m.Category)
           .WithMany(c => c.Motorcycles)
           .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<OrderDetail>()
           .HasOne(o => o.Motorcycle)
           .WithMany(m => m.OrderDetails)
           .HasForeignKey(o => o.MotorcycleId);

            modelBuilder.Entity<OrderDetail>()
           .HasOne(o => o.Order)
           .WithMany(m => m.OrderDetails)
           .HasForeignKey(o => o.OrderId);

            modelBuilder.Entity<Cart>()
          .HasOne(c => c.Motorcycle)
          .WithMany(m => m.Carts)
          .HasForeignKey(c => c.MotorcycleId);

        }
    }
}