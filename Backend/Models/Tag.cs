using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public required string TagName { get; set; }
        public string? Icon { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public ICollection<ProductTag>? ProductTags { get; set; }
    }
}
