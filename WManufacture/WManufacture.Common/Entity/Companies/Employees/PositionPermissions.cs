using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.Employees
{
    public class PositionPermissions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PermissionId { get; set; }

        [ForeignKey("PermissionId")]
        public Permission Permission { get; set; }

        [Required]
        public int PositionId { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
    }
}
