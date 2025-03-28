using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class HinhAnhSanPham
    {
        [Key]
        public int HinhAnhId { get; set; }
        public int BienTheId { get; set; }
        [ForeignKey("BienTheId")]
        public BienTheSanPham? BienTheSanPham { get; set; }
        public string URLHinhAnh { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; }
        public string? NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string? NguoiSua { get; set; }
        public bool IsActived { get; set; } = true;
        public bool IsDeleted { get; set; }
        public string? GhiChu { get; set; }

    }

}
