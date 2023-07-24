using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Data
{
    public class AppDbContext : DbContext  
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
      
        public DbSet<Category> Categories { get; set; }
        //Seed Data 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category() { Id = 1, Name = "Action", DisplayOrder = 1 },
               new Category() { Id = 2, Name = "Thriller", DisplayOrder = 2 },
               new Category() { Id = 3, Name = "Drama", DisplayOrder = 3 }

            );
        }

    }
}
