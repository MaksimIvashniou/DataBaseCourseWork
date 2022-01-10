using MaksimInc.Common.PManufacture.Entity.Branches.Products.Orders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.PManufacture.Entity.Branches.Customers
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BranchId { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
