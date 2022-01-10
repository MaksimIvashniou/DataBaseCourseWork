using MaksimInc.Common.WManufacture.Entity.Branches.Employees;
using MaksimInc.Common.WManufacture.Entity.Branches.WeldingMachines;
using MaksimInc.Common.WManufacture.Entity.Branches.WorkObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaksimInc.Common.WManufacture.Entity.Branches
{
    public class Branch
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
