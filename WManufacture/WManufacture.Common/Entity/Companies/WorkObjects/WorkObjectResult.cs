using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class WorkObjectResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkObjectId { get; set; }

        [ForeignKey("WorkObjectId")]
        public virtual WorkObject WorkObject { get; set; }

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public string CurrentStatus { get; set; }
    }
}
