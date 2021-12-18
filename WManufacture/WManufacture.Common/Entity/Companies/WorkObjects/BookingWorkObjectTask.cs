using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class BookingWorkObjectTask
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("WorkObjectTaskId")]
        public virtual WorkObjectTask WorkObjectTask { get; set; }

        [ForeignKey("WeldingMachineId")]
        public virtual WeldingMachine WeldingMachine { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Required]
        public int WorkObjectTaskId { get; set; }

        [Required]
        public int WeldingMachineId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        #endregion Keys

        [Required]
        public DateTime StartBooking { get; set; }

        [Required]
        public DateTime EndBooking { get; set; }

        #endregion DB columns

        public virtual WorkObjectTaskResult WorkObjectTaskResult { get; set; }
    }
}
