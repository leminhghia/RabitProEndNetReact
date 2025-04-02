using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Backend.RequestHelpers;
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



        public async Task<PagedList<SanPhamDto>> GetAllSanPhamAsync(IQueryable<SanPham> query,int pageNumber,int pageSize)
        {


            var sanPham = query
                  .Include(x => x.DanhMuc_SanPham!)
            .ThenInclude(x => x.DanhMuc)
                .Include(x => x.ThuongHieu_SanPham!)
                .ThenInclude(x => x.ThuongHieu)
                .Include(x => x.BienTheSanPham!)
                  .ThenInclude(x => x.HinhAnhSanPham)
                .Select(x => new SanPhamDto
                {
                    SanPhamId = x.SanPhamId,
                    TenSanPham = x.TenSanPham,
                    GiaGoc = x.GiaGoc,
                    DanhMuc = x.DanhMuc_SanPham != null ? x.DanhMuc_SanPham.Select(dm => new DanhMucDto
                    {
                        DanhMucId = dm.DanhMuc!.DanhMucId,
                        TenDanhMuc = dm.DanhMuc!.TenDanhMuc
                    }).ToList() : null,
                    ThuongHieu = x.ThuongHieu_SanPham != null ? x.ThuongHieu_SanPham.Select(x => new ThuongHieuDto
                    {
                        ThuongHieuId = x.ThuongHieu!.ThuongHieuId,
                        TenThuongHieu = x.ThuongHieu!.TenThuongHieu,
                    }).ToList() : null,

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
                .AsQueryable();
            return await PagedList<SanPhamDto>.ToPagedList(sanPham, pageNumber, pageSize);
        }



        public async Task<SanPhamDto?> GetById(int id)
        {
            return await _context.SanPham
                .Where(x => x.SanPhamId == id)
                  .Include(x => x.DanhMuc_SanPham!)
            .ThenInclude(x => x.DanhMuc)
                .Include(x => x.ThuongHieu_SanPham!)
                .ThenInclude(x => x.ThuongHieu)
                .Include(x => x.BienTheSanPham!)
                  .ThenInclude(x => x.HinhAnhSanPham)
                .Select(x => new SanPhamDto
                {
                    SanPhamId = x.SanPhamId,
                    TenSanPham = x.TenSanPham,
                    GiaGoc = x.GiaGoc,
                    DanhMuc = x.DanhMuc_SanPham != null ? x.DanhMuc_SanPham.Select(dm => new DanhMucDto
                    {
                        DanhMucId = dm.DanhMuc!.DanhMucId,
                        TenDanhMuc = dm.DanhMuc!.TenDanhMuc
                    }).ToList() : null,
                    ThuongHieu = x.ThuongHieu_SanPham != null ? x.ThuongHieu_SanPham.Select(x => new ThuongHieuDto
                    {
                        ThuongHieuId = x.ThuongHieu!.ThuongHieuId,
                        TenThuongHieu = x.ThuongHieu!.TenThuongHieu,
                    }).ToList() : null,

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
