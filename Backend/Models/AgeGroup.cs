using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{

    public class AgeGroup
    {
        [Key]
        public int AgeGroupId { get; set; }
        public int Age { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public int CreateBy { get; set; }
        public List<ProductSize>? ProductSizes { get; set; }
    }

}
