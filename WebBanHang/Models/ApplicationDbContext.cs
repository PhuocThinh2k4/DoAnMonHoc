using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace WebBanHang.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Dell", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Asus", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Macbook", DisplayOrder = 3 });
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Laptop Dell Inspiron 15 3520 i5", Price = 1300, CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop Dell Vostro 15 3520 i5", Price = 1500, CategoryId = 1 },
            new Product { Id = 3, Name = "Laptop Dell Inspiron 15 3520 i3", Price = 1400, CategoryId = 1 },
            new Product { Id = 4, Name = "Laptop Dell Vostro 15 3520 i3", Price = 1800, CategoryId = 1 },
            new Product { Id = 5, Name = "Laptop Asus Vivobook Go 15", Price = 1650, CategoryId = 1 },
            new Product { Id = 6, Name = "Laptop Asus Vivobook 15 X1504ZA i3", Price = 1750, CategoryId = 1 },
            new Product { Id = 7, Name = "Laptop Asus Vivobook 15 OLED A1505ZA i5", Price = 2850, CategoryId = 1 },
            new Product { Id = 8, Name = "Laptop Asus TUF Gaming F15 FX507ZC4 i5", Price = 2950, CategoryId = 1 },
            new Product { Id = 9, Name = "Laptop Apple MacBook Air 13 inch M1", Price = 3200, CategoryId = 1 },
            new Product { Id = 10, Name = "Laptop Apple MacBook Air 13 inch M2", Price = 2450, CategoryId = 1 },
            new Product { Id = 11, Name = "Laptop Apple MacBook Air 15 inch M2", Price = 2500, CategoryId = 2 },
            new Product { Id = 12, Name = "Laptop Apple MacBook Pro 14 inch M3", Price = 1250, CategoryId = 2 });
        }

    }
}
