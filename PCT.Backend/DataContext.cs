using Microsoft.EntityFrameworkCore;
using PCT.Backend.Entities;
using PCT.Backened.Entities;

namespace PCT.Backened
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual void EnsureSeeded()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> ProductCategories { get; set; }
        public DbSet<Unit> ProductUnits { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Carrier> carriers { get; set; }
        public DbSet<Location> locations { get; set; }
    }
}
