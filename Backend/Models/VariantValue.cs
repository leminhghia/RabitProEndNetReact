using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class VariantValue
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Variant_id { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public Variant? Variant { get; set; }
    }
}
