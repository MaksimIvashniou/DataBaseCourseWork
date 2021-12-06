using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class WorkObjectTaskResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookingWorkObjectTaskId { get; set; }

        [ForeignKey("BookingWorkObjectTaskId")]
        public virtual BookingWorkObjectTask BookingWorkObjectTask { get; set; }

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public string CurrentStatus { get; set; }
    }
}
