using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add seed data for Category model:
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Jeep",
                },
                new Category()
                {
                    Id = 2,
                    Name = "BMW",
                },
                new Category()
                {
                    Id = 3,
                    Name = "Mopar",
                }
                );

            // Add seed data for Content model:
            modelBuilder.Entity<Content>().HasData(
               new Content()
               {
                   Id=1,
                   Title="topic",
                   Body = "stuff",
                   Author = "people",
                   PublishDate = "10/25/20",
                   CategoryId = 1
               },
                new Content()
                {
                Id = 2,
                   Title = "topic",
                   Body = "stuff",
                   Author = "people",
                   PublishDate = "10/25/20",
                   CategoryId = 2
               },
               new Content()
               {
                   Id = 3,
                   Title = "topic",
                   Body = "stuff",
                   Author = "people",
                   PublishDate = "10/25/20",
                   CategoryId = 3,
               }

              );

            base.OnModelCreating(modelBuilder);
        }
    }
}
