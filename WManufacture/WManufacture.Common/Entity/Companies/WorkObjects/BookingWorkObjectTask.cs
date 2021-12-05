using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WorkObjects
{
    public class BookingWorkObjectTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WorkObjectTaskId { get; set; }

        [ForeignKey("WorkObjectTaskId")]
        public WorkObjectTask WorkObjectTask { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public DateTime EnDateTime { get; set; }
    }
}
