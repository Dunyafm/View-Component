using LessonMigration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData(
            new Setting
            {
                Id = 1,
                HomeProductTake = 8,
                LoadTake = 4
            }
            );


            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                IsDeleted = false,
                Title = "Blog1",
                Description = "Blog1 desctiption",
                Image = "blog-feature-img-1.jpg"

            },

            new Blog
            {
                Id = 2,
                IsDeleted = false,
                Title = "Blog2",
                Description = "Blog2 desctiption",
                Image = "blog-feature-img-3.jpg"

            },

            new Blog
            {
                Id = 3,
                IsDeleted = false,
                Title = "Blog3",
                Description = "Blog3 desctiption",
                Image = "blog-feature-img-4.jpg"

            }

        );

        }
    }
}
