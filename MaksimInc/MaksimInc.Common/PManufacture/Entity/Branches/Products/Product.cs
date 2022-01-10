using MaksimInc.Common.PManufacture.Entity.Branches.Products.Orders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaksimInc.Common.PManufacture.Entity.Branches.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public int OrderDetailsId { get; set; }

        [ForeignKey("OrderDetailsId")]
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
