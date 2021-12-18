using System;
using System.ComponentModel.DataAnnotations;

namespace WManufacture.Common.Entity
{
    public class History
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        #endregion

        [Required]
        public string ModelName { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        #endregion
    }
}
