using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.WManufacture.Entity.Branches.Employees
{
    public class PositionPermissions
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("PermissionId")]
        public virtual Permission Permission { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        [Required]
        public int PermissionId { get; set; }

        [Required]
        public int PositionId { get; set; }

        #endregion Keys

        #endregion DB columns
    }
}
