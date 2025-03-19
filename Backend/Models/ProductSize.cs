using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProductSize
    {
        [Key]
        public int ProSizeId { get; set; }

        public int ProId { get; set; }
        [ForeignKey("ProId")]
        public Product? Product { get; set; }  

        public int SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Size? Size { get; set; }
        public required string Gender { get; set; }

        public int AgeGroupId { get; set; }
        [ForeignKey("AgeGroupId")]
        public AgeGroup? AgeGroup { get; set; }  
    }

}
