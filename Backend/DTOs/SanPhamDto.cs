using Backend.Models;

namespace Backend.DTOs
{
    public class SanPhamDto
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public float GiaGoc { get; set; }
        public int DanhMucId { get; set; }

        public string? TenDanhMuc { get; set; }
        public int ThuongHieuId { get; set; }
        public string? TenThuongHieu { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public byte IsActived { get; set; } = 1;
        public List<BienTheSanPhamDto>? BienTheSanPham { get; set; } = null;

    }
}
