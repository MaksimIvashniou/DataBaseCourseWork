using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class WorkObjectTask
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("WorkObjectId")]
        public virtual WorkObject WorkObject { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CompanyObjectId { get; set; }

        public virtual BookingWorkObjectTask BookingWorkObjectTask { get; set; }
    }
}
