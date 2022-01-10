using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.Employees
{
    public class PersonalInfo
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        #endregion Keys
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string AdditionalInfo { get; set; }

        [Required]
        public string WorkPhone { get; set; }

        [Required]
        public string Rank { get; set; }

        [Required]
        public DateTime CertificateDate { get; set; }

        [Required]
        public bool IsUserBlocked { get; set; }

        #endregion DB columns
    }
}
