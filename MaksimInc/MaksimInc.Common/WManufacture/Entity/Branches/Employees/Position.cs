using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaksimInc.Common.WManufacture.Entity.Branches.Employees
{
    public class Position
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        #endregion Keys

        [Required]
        public string Name { get; set; }

        #endregion DB columns

        public virtual List<Employee> Employees { get; set; }

        public virtual List<PositionPermissions> PositionPermissions { get; set; }
    }
}
