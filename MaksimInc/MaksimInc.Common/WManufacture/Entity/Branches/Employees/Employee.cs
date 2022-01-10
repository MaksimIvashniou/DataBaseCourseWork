using MaksimInc.Common.WManufacture.Entity.Branches.WorkObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.Employees
{
    public class Employee
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [Required]
        public int BranchId { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("PersonalInfoId")]
        public virtual PersonalInfo PersonalInfo { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

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
