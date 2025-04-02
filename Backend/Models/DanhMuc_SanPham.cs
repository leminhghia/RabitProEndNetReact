using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class DanhMuc_SanPham
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SanPham")]
        public int SanPhamId { get; set; }
        public SanPham? SanPham { get; set; }

        [ForeignKey("DanhMuc")]
        public int DanhMucId { get; set; }
        public DanhMuc? DanhMuc { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
    }
}
