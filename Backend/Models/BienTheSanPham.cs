using Backend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Backend.Models
{
    public class BienTheSanPham
    {
        [Key]
        public int BienTheId { get; set; }
        public int SanPhamId { get; set; }
        [ForeignKey("SanPhamId")]
        public SanPham? SanPham  { get; set; }
        public string Size { get; set; } = string.Empty;
        public string MauSac { get; set; } = string.Empty;
        [Required]
        public float GiaBan { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; }
        public string? NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string? NguoiSua { get; set; }
        public bool IsActived { get; set; } = true;
        public bool IsDeleted { get; set; }
        public string? GhiChu { get; set; }

        
        public  List<HinhAnhSanPham>? HinhAnhSanPham { get; set; }
    }

}
