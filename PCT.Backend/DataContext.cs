using Microsoft.EntityFrameworkCore;
using PCT.Backend.Entities;
using PCT.Backened.Entities;

namespace PCT.Backend
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
        public DbSet<OptionRoute> OptionRoutes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleOption> RoleOptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<CMSContentImpact> CMSContentImpact { get; set; }
        public DbSet<CMSContentLeadership> CMSContentLeadership { get; set; }
        public DbSet<CMSContentRoles> CMSContentRoles { get; set; }
        public DbSet<CMSContentRoles_dataQ> CMSContentRoles_dataQ { get; set; }
        public DbSet<CMSContentPage> CMSContentPage { get; set; }
        public DbSet<CMSContentPageItem> CMSContentPageItem { get; set; }
        public DbSet<CMSContentPageSection> CMSContentPageSection { get; set; }
        public DbSet<Category> ProductCategories { get; set; }
        public DbSet<Unit> ProductUnits { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Carrier> carriers { get; set; }
        public DbSet<Location> locations { get; set; }
    }
}
