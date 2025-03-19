using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProductImages
    {
        [Key]
        public int ProImgId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
