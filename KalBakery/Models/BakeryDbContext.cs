using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KalBakery.Models
{
    public class BakeryDbContext : IdentityDbContext<IdentityUser>
    {
        public BakeryDbContext(DbContextOptions <BakeryDbContext> options):base (options)
        {
        }

        public DbSet<Cake> Cakes { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Cake data

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 1,
                Name = "Chocolate Cake",
                Price = 12.95M,
                Description = "Our famous Choco Cake!",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",

            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 2,
                Name = "Vanilla Cake",
                Price = 10.95M,
                Description = "Our famous Vanilla Cake!",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",

            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 3,
                Name = "Strawberry Cake",
                Price = 14.95M,
                Description = "Our famous strawberry garden to table cake!",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",

            });

           
        }
    }
}
