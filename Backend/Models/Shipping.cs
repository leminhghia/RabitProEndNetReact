using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Shipping
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public required string ShippingName { get; set; }
        public float Cost { get; set; }
        public int EstimatedDeliveryDays { get; set; }

        public ICollection<ProductShipping>? ProductShippings { get; set; }
    }
}
