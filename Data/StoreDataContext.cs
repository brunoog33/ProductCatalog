using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.Data 
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User ID=SA;Password=");
        }
    }
}