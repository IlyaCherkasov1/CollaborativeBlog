using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class AppDbContext : DbContext
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "All-fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Chese cake", Description = "Cheese all the way" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies", Description = "Get in the mood for a seasonal pie" });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Strawberry pie",
                Price = 15.95M,
                ShortDescription = "yummy",
                LongDescription = "default description",
                AllergyInformation = "",
                ImageUrl = "/images/cheesecake1.png",
                ImageThumbnailUrl = "",
                IsPieOfTheWeek = false,
                InStock = true,
                CotegoryId = 1,
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Chese cake",
                Price = 30.95M,
                ShortDescription = "delicious",
                LongDescription = "default description",
                AllergyInformation = "",
                ImageUrl = "/images/cheesecake2.png",
                ImageThumbnailUrl = "",
                IsPieOfTheWeek = true,
                InStock = true,
                CotegoryId = 2,
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Rhubarb Pie",
                Price = 10.95M,
                ShortDescription = "savory",
                LongDescription = "default description",
                AllergyInformation = "",
                ImageUrl = "/images/cheesecake3.png",
                ImageThumbnailUrl = "",
                IsPieOfTheWeek = true,
                InStock = true,
                CotegoryId = 3,
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Pumpking pie",
                Price = 12.95M,
                ShortDescription = "tasty",
                LongDescription = "default description",
                AllergyInformation = "",
                ImageUrl = "/images/cheesecake4.png",
                ImageThumbnailUrl = "",
                IsPieOfTheWeek = true,
                InStock = true,
                CotegoryId = 1,
            });


        }
    }
}
