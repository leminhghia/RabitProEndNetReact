using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ThuongHieu_SanPham
    {
        [Key]
        public int Id { get; set; } 

        [ForeignKey("SanPham")]
        public int SanPhamId { get; set; }
        public SanPham? SanPham { get; set; }

        [ForeignKey("ThuongHieuId")]
        public int ThuongHieuId { get; set; }
        public ThuongHieu? ThuongHieu { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
    }
}
