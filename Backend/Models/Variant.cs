using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Variant
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid Product_id { get; set; }
        [ForeignKey(nameof(VariantAttributeValue))]
        public Guid VariantAttributeValue_id { get; set; }

        public Product? Product { get; set; }
        public VariantAttributeValue? VariantAttributeValue { get; set; }

        public VariantValue? VariantValue { get; set; }
    }
}
