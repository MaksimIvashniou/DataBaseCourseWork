using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class BookingWorkObjectTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int? WorkObjectTaskId { get; set; }

        [ForeignKey("WorkObjectTaskId")]
        public virtual WorkObjectTask WorkObjectTask { get; set; }

        public int? WeldingMachineId { get; set; }

        [ForeignKey("WeldingMachineId")]
        public virtual WeldingMachine WeldingMachine { get; set; }

        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public virtual WorkObjectTaskResult WorkObjectTaskResult { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public DateTime EnDateTime { get; set; }
    }
}
