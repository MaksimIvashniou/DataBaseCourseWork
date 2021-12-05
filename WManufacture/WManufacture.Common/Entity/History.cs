using System;
using System.ComponentModel.DataAnnotations;

namespace WManufacture.Common.Entity
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ModelName { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }
    }
}
