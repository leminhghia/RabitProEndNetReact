using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<ThuongHieu> ThuongHieu { get; set; }
        public DbSet<BienTheSanPham> BienTheSanPham { get; set; }
        public DbSet<HinhAnhSanPham> HinhAnhSanPham { get; set; }

      

    }
}
