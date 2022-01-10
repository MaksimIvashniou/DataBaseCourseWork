using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaksimInc.Common.WManufacture.Entity.Branches.Employees
{
    public class Permission
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        #endregion Keys

        [Required]
        public string Name { get; set; }

        #endregion DB columns

        public virtual List<PositionPermissions> PositionPermissions { get; set; }
    }
}
