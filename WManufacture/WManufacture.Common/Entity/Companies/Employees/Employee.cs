using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.Employees
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PersonalInfoId { get; set; }

        [ForeignKey("PersonalInfoId")]
        public virtual PersonalInfo PersonalInfo { get; set; }

        [Required]
        public int PositionId { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
