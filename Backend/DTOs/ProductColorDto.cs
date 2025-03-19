using Backend.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class ProductColorDto
    {
        public ColorDto? Color { get; set; }
        public int Quantity { get; set; }
        public ProductImagesDto? Images { get; set; }
        public PriceDto? Prices { get; set; } 
    }
}
