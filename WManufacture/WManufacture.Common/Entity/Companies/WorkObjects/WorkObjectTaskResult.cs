using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class WorkObjectTaskResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkObjectTaskId { get; set; }

        [ForeignKey("WorkObjectTaskId")]
        public virtual WorkObjectTask WorkObjectTask { get; set; }

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public string CurrentStatus { get; set; }
    }
}
