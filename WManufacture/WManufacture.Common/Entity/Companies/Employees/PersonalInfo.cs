using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.Employees
{
    public class PersonalInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Birthday { get; set; }

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
    }
}
