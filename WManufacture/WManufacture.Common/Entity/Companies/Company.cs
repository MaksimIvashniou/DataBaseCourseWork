using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Common.Entity.Companies
{
    public class Company
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }
        
        #endregion Keys
        
        [Required]
        public string Name { get; set; }

        #endregion DB columns

        [Required]
        public virtual List<Employee> Employees { get; set; }

        [Required]
        public virtual List<WeldingMachine> WeldingMachines { get; set; }

        [Required]
        public virtual List<WorkObject> WorkObjects { get; set; }
    }
}
