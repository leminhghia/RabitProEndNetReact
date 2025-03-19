using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class ProductImagesDto
    {
        [Key]
        public int ProImgId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
