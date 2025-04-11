using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Attribute
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public required string AttributeName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public ICollection<AttributeValues>? AttributeValues { get; set; }
        public ICollection<ProductAttribute>? ProductAttributes { get; set; }
    }
}

