using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Price
    {
        [Key]
        public int PriId { get; set; }
        public long PriceValue { get; set; }
        public long DiscountPrice { get; set; }
        public int ProColorId { get; set; }
        [ForeignKey(nameof(ProColorId))]
        public ProductColor? ProductColor { get; set; }
    }

}
