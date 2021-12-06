using Microsoft.EntityFrameworkCore;
using WManufacture.Common.Entity;
using WManufacture.Common.Entity.Companies;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Common.Entity.Companies.WorkObjects;

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

        #region Employees

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PersonalInfo> PersonalInfos { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<PositionPermissions> PositionPermissions { get; set; }

        #endregion

        #region WeldingMachines

        public DbSet<ModelCharacteristic> ModelCharacteristics { get; set; }

        public DbSet<ModelOfWeldingMachine> ModelOfWeldingMachines { get; set; }

        public DbSet<WeldingMachine> WeldingMachines { get; set; }

        #endregion

        #region WorkObjects

        public DbSet<BookingWorkObjectTask> BookingWorkObjectTasks { get; set; }

        public DbSet<WorkObject> WorkObjects { get; set; }

        public  DbSet<WorkObjectResult> WorkObjectResults { get; set; }

        public DbSet<WorkObjectTask> WorkObjectTasks { get; set; }

        public DbSet<WorkObjectTaskResult> WorkObjectTaskResults { get; set; }

        #endregion

        #endregion

        public DbSet<History> Histories { get; set; }
    }
}
