using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.WorkObjects
{
    public class WorkObjectTask
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("WorkObjectId")]
        public virtual WorkObject WorkObject { get; set; }

        [Required]
        public int WorkObjectId { get; set; }

        #endregion Keys

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        #endregion DB columns

        public virtual List<BookingWorkObjectTask> BookingWorkObjectTasks { get; set; }
    }
}
