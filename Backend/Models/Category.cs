using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        public Guid? Parent_id { get; set; }
        [MaxLength(255)]
        public required string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool Active { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public ICollection<ProductCategory>? ProductCategories { get; set; }
    }
}
