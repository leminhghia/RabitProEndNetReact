using Backend.Models;
using System.Text.Json.Serialization;

namespace Backend.DTOs
{
    public class SanPhamDto
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public float GiaGoc { get; set; }
        public List<DanhMucDto>? DanhMuc { get; set; }
        public List<ThuongHieuDto>? ThuongHieu { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public byte IsActived { get; set; } = 1;
        public List<BienTheSanPhamDto>? BienTheSanPham { get; set; } = null;
   

    }
}
