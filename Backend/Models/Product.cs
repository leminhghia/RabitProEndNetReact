using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(255)]
        public required string ProductName { get; set; }
        public Guid? BrandId { get; set; }
        public Brand? Brand { get; set; }

        public float? RegularPrice { get; set; }
        public float? DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public required string Gender { get; set; }

        [MaxLength(255)]
        public string? ShortDescription { get; set; }

        public string? ProductDescription { get; set; }
        public float? ProductWeight { get; set; }
        public bool IsFlashSale { get; set; } = false;
        public bool Published { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; } 
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }

        public ICollection<ProductCategory>? ProductCategories { get; set; }
        public ICollection<ProductTag>? ProductTags { get; set; }
        public ICollection<ProductAttribute>? ProductAttributes { get; set; }
        public ICollection<ProductShipping>? ProductShippings { get; set; }
        public ICollection<FlashSale>? FlashSale { get; set; }

        public ICollection<Variant>? Variants { get; set; }
        public ICollection<Gallery>? Galleries { get; set; }
    }
}
