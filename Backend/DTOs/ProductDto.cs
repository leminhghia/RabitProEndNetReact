using Backend.Models;

namespace Backend.DTOs
{
    public class ProductDto
    {
        public int ProId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Gender { get; set; }

        public CategoryDto? Category { get; set; }
        public BrandDto? Brand { get; set; }
        public List<ProductSizeDto>? ProductSizes { get; set; }
        public List<ProductColorDto>? ProductColors { get;set; }

    }
}
