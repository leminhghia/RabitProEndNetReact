using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{

    public class ProductAttribute
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid Product_id { get; set; }
        [ForeignKey(nameof(Attribute))]
        public Guid Attribute_id { get; set; }

        public Product? Product { get; set; }
        public Attribute? Attribute { get; set; }
    }
}
