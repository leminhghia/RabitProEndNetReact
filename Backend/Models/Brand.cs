using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public required string BrandName { get; set; }

        [MaxLength(255)]
        public string? LogoPath { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
