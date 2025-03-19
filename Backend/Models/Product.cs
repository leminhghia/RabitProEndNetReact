using Backend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Product
    {
        [Key]
        public int ProId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Gender { get; set; }
        public int CatId { get; set; }
        [ForeignKey(nameof(CatId))]
        public Category Category { get; set; }= new();
        public int BraId { get; set; }
        [ForeignKey(nameof(BraId))]
        public Brand Brand { get; set; }= new();
        public List<ProductSize> ProductSizes { get; set; }= new();
        public List<ProductColor> ProductColors { get;set; }= new();

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;

    }
}
