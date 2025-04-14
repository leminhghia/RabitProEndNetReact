using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class VariantAttributeValue
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(AttributeValues))]
        public Guid AttributeValue_id { get; set; }

        public AttributeValues? AttributeValues { get; set; }
        public ICollection<Variant>? Variants { get; set; }
    }
}
