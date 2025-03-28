using Backend.Models;
using System.Text.Json.Serialization;

namespace Backend.DTOs
{
    public class HinhAnhSanPhamDto
    {
        public int HinhAnhId { get; set; }
        [JsonIgnore]
        public int BienTheId { get; set; }
        public string URLHinhAnh { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public string? GhiChu { get; set; }
        public bool IsActived { get; set; } = true;
    }

}
