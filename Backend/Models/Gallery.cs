using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Gallery
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid Product_id { get; set; }
        [ForeignKey(nameof(AttributeValues))]
        public Guid AttributeValue_id { get; set; }

        [MaxLength(255)]
        public required string ImagePath { get; set; }
        [MaxLength(255)]
        public string? Caption { get; set; }
        public int DisplayOrder { get; set; }
        public Product? Product { get; set; }
        public AttributeValues? AttributeValues { get; set; }
    }
}
