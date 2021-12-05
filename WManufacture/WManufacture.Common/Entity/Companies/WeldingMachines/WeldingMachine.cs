using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Common.Entity.Companies.WeldingMachines
{
    public class WeldingMachine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        [Required]
        public int ModelWeldingMachineId { get; set; }

        [ForeignKey("ModelWeldingMachineId")]
        public virtual ModelOfWeldingMachine ModelOfWeldingMachine { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CertificationDate { get; set; }

        public virtual List<WorkObjectTask> WorkObjectTasks { get; set; }
    }
}
