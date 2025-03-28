using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class DanhMuc
    {
        [Key]
        public int DanhMucId{ get; set; }

        [Required, MaxLength(255)]
        public string TenDanhMuc { get; set; } = string.Empty;

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public string? NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string? NguoiSua { get; set; }
        public string? GhiChu { get; set; }
        public byte IsActived { get; set; } = 1;

        public List<SanPham>? SanPham { get; set; }
    }
}
