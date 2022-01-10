using MaksimInc.Common.PManufacture.Entity.Branches.Employees;
using MaksimInc.Common.PManufacture.Entity.Branches.Machines;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.PManufacture.Entity.Branches.WorkShifts
{
    public class WorkShift
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BranchId { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Required]
        public int MachineId { get; set; }

        [ForeignKey("MachineId")]
        public virtual Machine Machine { get; set; }
    }
}
