using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Brand
    {
        [Key]
        public int BraId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public int CreateBy { get; set; }
        public List<Product>? Products { get; set; }
    }
}
