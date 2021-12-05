using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WManufacture.Common.Entity.Companies.WeldingMachines;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class WorkObjectTask
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("WorkObjectId")]
        public virtual WorkObject WorkObject { get; set; }

        public int? WeldingMachineId { get; set; }

        [ForeignKey("WeldingMachineId")]
        public virtual WeldingMachine WeldingMachine { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CompanyObjectId { get; set; }

        public virtual List<BookingWorkObjectTask> BookingWorkObjectTasks { get; set; }

        public virtual List<WorkObjectTaskResult> WorkObjectTaskResults { get; set; }
    }
}
