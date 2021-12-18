using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class WorkObject
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

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
