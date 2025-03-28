using Microsoft.AspNetCore.Mvc;

namespace Backend.DTOs
{
    public class ThuongHieuDto 
    {
        public int ThuongHieuId { get; set; }
        public string TenThuongHieu { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public byte IsActived { get; set; } = 1;
    }
}
