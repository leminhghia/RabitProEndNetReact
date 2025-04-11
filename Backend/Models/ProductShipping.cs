using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProductShipping
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid Product_id { get; set; }
        [ForeignKey(nameof(Shipping))]
        public Guid Shipping_id { get; set; }
        public float? ShipCharge { get; set; }
        public bool Free { get; set; }
        public Product? Product { get; set; }
        public Shipping? Shipping { get; set; }
    }
}
