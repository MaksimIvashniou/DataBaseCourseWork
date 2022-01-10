using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.WorkObjects
{
    public class WorkObjectTaskResult
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("BookingWorkObjectTaskId")]
        public virtual BookingWorkObjectTask BookingWorkObjectTask { get; set; }

        [Required]
        public int BookingWorkObjectTaskId { get; set; }

        #endregion Keys

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public string CurrentStatus { get; set; }

        #endregion DB columns
    }
}
