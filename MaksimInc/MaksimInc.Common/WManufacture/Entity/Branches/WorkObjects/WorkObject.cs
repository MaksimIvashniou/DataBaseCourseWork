using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.WorkObjects
{
    public class WorkObject
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [Required]
        public int CompanyId { get; set; }

        #endregion Keys

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        #endregion DB columns

        public virtual WorkObjectResult WorkObjectResult { get; set; }
    
        public virtual List<WorkObjectTask> WorkObjectTasks { get; set; }
    }
}
