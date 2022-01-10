using Microsoft.EntityFrameworkCore;

namespace MaksimInc.Infrastructure.Databases
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
    }
}
