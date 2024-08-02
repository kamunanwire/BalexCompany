using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class BulkyBookDbContext:DbContext
    {
        public BulkyBookDbContext(DbContextOptions<BulkyBookDbContext> options):base (options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }// this line creates a table called Categories in the database from moled Category
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Action", DisplayOrder=1 },
                 new Category { Id = 2, Name = "sci", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );
        }
    }
}
