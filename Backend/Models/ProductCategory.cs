using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid Product_id { get; set; }
        [ForeignKey(nameof(Category))]
        public int Category_id { get; set; }

        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}
