using MaksimInc.Common.PManufacture.Entity.Branches.Customers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.PManufacture.Entity.Branches.Products.Orders
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual List<OrderDetails> Details { get; set; }
    }
}
