using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<ThuongHieu> ThuongHieu { get; set; }
        public DbSet<BienTheSanPham> BienTheSanPham { get; set; }
        public DbSet<HinhAnhSanPham> HinhAnhSanPham { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
      .HasData(
          new IdentityRole { Id = "683ef5e6-a3c9-4be0-bded-0b64256e9f0a", Name = "Member", NormalizedName = "MEMBER" },
          new IdentityRole { Id = "7afca44c-517f-4632-b41e-cc774c90d0b4", Name = "Admin", NormalizedName = "ADMIN" }
      );
        }


    }
}
