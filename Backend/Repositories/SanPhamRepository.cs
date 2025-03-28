using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class SanPhamRepository : GenericRepository<SanPham>
    {
        private readonly AppDbContext _context;

        public SanPhamRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        

        public async Task<IEnumerable<SanPhamDto>> GetAllSanPhamAsync()
        {
        
            
            return await _context.SanPham
                  .Include(x => x.DanhMuc)
                  .Include(x => x.BienTheSanPham!)
                  .ThenInclude(x=>x.HinhAnhSanPham)
                  .Include(x=>x.ThuongHieu)
                .Select(x => new SanPhamDto
                {
                    SanPhamId = x.SanPhamId,
                    TenSanPham = x.TenSanPham,  
                    GiaGoc = x.GiaGoc,
                    DanhMucId = x.DanhMucId,
                    TenDanhMuc = x.DanhMuc != null ? x.DanhMuc.TenDanhMuc : null,
                    ThuongHieuId = x.ThuongHieuId,
                    TenThuongHieu = x.ThuongHieu != null ? x.ThuongHieu.TenThuongHieu : null,
                    BienTheSanPham = x.BienTheSanPham != null ? x.BienTheSanPham.Select(x => new BienTheSanPhamDto
                    {
                        BienTheId = x.BienTheId,
                        Size = x.Size,
                        MauSac = x.MauSac,
                        GiaBan = x.GiaBan,
                        SoLuong = x.SoLuong,
                        HinhAnh = x.HinhAnhSanPham != null ? x.HinhAnhSanPham.Select(x => new HinhAnhSanPhamDto
                        {
                            HinhAnhId = x.HinhAnhId,
                            URLHinhAnh = x.URLHinhAnh
                        }).ToList():null,
                    }).ToList() : null,
                    NgayTao = x.NgayTao,
                    NgaySua = x.NgaySua,    
                    IsActived = x.IsActived,
                })
                .ToListAsync();
        }

        public async Task<SanPhamDto?> GetById(int id)
        {
            return await _context.SanPham
                .Where(x => x.SanPhamId == id)
                .Include(x => x.DanhMuc)
                .Include(x => x.ThuongHieu)
                .Include(x => x.BienTheSanPham!)
                  .ThenInclude(x => x.HinhAnhSanPham)
                .Select(x => new SanPhamDto
                {
                    SanPhamId = x.SanPhamId,
                    TenSanPham = x.TenSanPham,
                    GiaGoc = x.GiaGoc,
                    DanhMucId = x.DanhMucId,
                    TenDanhMuc = x.DanhMuc != null ? x.DanhMuc.TenDanhMuc : null,
                    ThuongHieuId = x.ThuongHieuId,
                    TenThuongHieu = x.ThuongHieu != null ? x.ThuongHieu.TenThuongHieu : null,
                    BienTheSanPham = x.BienTheSanPham != null ? x.BienTheSanPham.Select(x => new BienTheSanPhamDto
                    {
                        BienTheId = x.BienTheId,
                        Size = x.Size,
                        MauSac = x.MauSac,
                        GiaBan = x.GiaBan,
                        SoLuong = x.SoLuong,
                        HinhAnh = x.HinhAnhSanPham != null ? x.HinhAnhSanPham.Select(x => new HinhAnhSanPhamDto
                        {
                            HinhAnhId = x.HinhAnhId,
                            URLHinhAnh = x.URLHinhAnh
                        }).ToList() : null,
                    }).ToList() : null,
                    NgayTao = x.NgayTao,
                    NgaySua = x.NgaySua,
                    IsActived = x.IsActived,
                })
                .FirstOrDefaultAsync(); 
        }

    }
}
