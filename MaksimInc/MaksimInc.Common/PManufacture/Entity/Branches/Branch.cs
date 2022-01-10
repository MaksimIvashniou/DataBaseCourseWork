using MaksimInc.Common.PManufacture.Entity.Branches.Customers;
using MaksimInc.Common.PManufacture.Entity.Branches.Employees;
using MaksimInc.Common.PManufacture.Entity.Branches.Machines;
using MaksimInc.Common.PManufacture.Entity.Branches.WorkShifts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaksimInc.Common.PManufacture.Entity.Branches
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

        public virtual List<Customer> Customers { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public virtual List<Machine> Machines { get; set; }

        public virtual List<WorkShift> WorkShifts { get; set; }
    }
}
