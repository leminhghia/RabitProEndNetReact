using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class SanPham 
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public float GiaGoc { get; set; }
        public int DanhMucId { get; set; }
        public DanhMuc? DanhMuc { get; set; }
        public int ThuongHieuId { get; set; }
        public ThuongHieu? ThuongHieu { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public string? GhiChu { get; set; }
        public byte IsActived { get; set; } = 1;
        public  List<BienTheSanPham>? BienTheSanPham { get; set; } 
    }
}
