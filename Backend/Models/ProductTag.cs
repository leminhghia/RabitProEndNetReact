using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProductTag
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid Product_id { get; set; }
        [ForeignKey(nameof(Tag))]
        public int Tag_id { get; set; }

        public Product? Product { get; set; }
        public Tag? Tag { get; set; }
    }
}
