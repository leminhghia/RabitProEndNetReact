using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    
    public class AttributeValues
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string? AttributeValue { get; set; }
        [MaxLength(255)]
        public string? Color { get; set; }
        [ForeignKey(nameof(Attribute))]

        public Guid Attribute_id { get; set; }
        public Attribute? Attribute { get; set; }

        public ICollection<VariantAttributeValue>? VariantAttributeValues { get; set; }
    }
}
