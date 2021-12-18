using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Common.Entity.Companies.Employees
{
    public class Employee
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        [ForeignKey("PersonalInfoId")]
        public virtual PersonalInfo PersonalInfo { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public int PersonalInfoId { get; set; }

        [Required]
        public int PositionId { get; set; }

        #endregion Keys

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        #endregion DB columns

        public virtual List<BookingWorkObjectTask> BookingWorkObjectTasks { get; set; }
    }
}
