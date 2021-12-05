using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WManufacture.Common.Entity.Companies.Employees
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public virtual List<PositionPermissions> PositionPermissions { get; set; }
    }
}
