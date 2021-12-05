using Microsoft.EntityFrameworkCore;
using WManufacture.Common.Entity;
using WManufacture.Common.Entity.Companies;

namespace WManufacture.Infrastructure.Databases
{
    public class WManufactureContext : DbContext
    {
        public WManufactureContext(DbContextOptions<WManufactureContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region Companies

        public DbSet<Company> Companies { get; set; }

        #endregion

        public DbSet<History> Histories { get; set; }
    }
}
