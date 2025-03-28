using Backend.Models;
using System.Text.Json.Serialization;

namespace Backend.DTOs
{
    public class BienTheSanPhamDto
    {
        public int BienTheId { get; set; }
        [JsonIgnore]
        public int SanPhamId { get; set; }
        public string Size { get; set; } = string.Empty;
        public string MauSac { get; set; } = string.Empty;
        public float GiaBan { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public string? GhiChu { get; set; }
        public bool IsActived { get; set; } = true;

        public List<HinhAnhSanPhamDto>? HinhAnh { get; set; }
   

    }
}

