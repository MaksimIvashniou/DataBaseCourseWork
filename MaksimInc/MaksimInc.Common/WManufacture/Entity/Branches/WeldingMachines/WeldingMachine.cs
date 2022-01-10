using MaksimInc.Common.WManufacture.Entity.Branches.WorkObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.WeldingMachines
{
    public class WeldingMachine
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("ModelWeldingMachineId")]
        public virtual ModelOfWeldingMachine ModelOfWeldingMachine { get; set; }

        [Required]
        public int CompanyId { get; set; }
        
        [Required]
        public int ModelWeldingMachineId { get; set; }

        #endregion Keys

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CertificationDate { get; set; }

        #endregion DB columns

        public virtual List<BookingWorkObjectTask> BookingWorkObjectTasks { get; set; }
    }
}
