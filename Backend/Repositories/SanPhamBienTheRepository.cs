using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class SanPhamBienTheRepository : GenericRepository<BienTheSanPham>
    {
        private readonly AppDbContext _context;
        public SanPhamBienTheRepository(AppDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<BienTheSanPhamDto>> GetAllSanPhamBTAsync()
        {
            return await _context.BienTheSanPham
                .Include(x=>x.SanPham)
                .Include(x=>x.HinhAnhSanPham)
                .Select(x=> new BienTheSanPhamDto
                {
                    BienTheId = x.BienTheId,
                    
                }).ToListAsync();
        }


    }
}
//    "SanPhamId": 2,
//  "TenSanPham": "Giày Adidas UltraBoost",
//  "MoTa": "Đế boost êm ái, chạy bộ thoải mái",
//  "GiaGoc": 2500000,
//  "DanhMucId": 3,
//  "ThuongHieuId": 2,
//  "IsActived": 1,
//  "BienTheSanPham": [
//    {
//        "BienTheID": 201,
//      "Size": "42",
//      "MauSac": "Trắng",
//      "GiaBan": 2300000,
//      "SoLuong": 10,
//      "HinhAnh": [
//        { "HinhAnhID": 1001, "URLHinhAnh": "https://example.com/giay-adidas-42-trang.jpg" },
//        { "HinhAnhID": 1002, "URLHinhAnh": "https://example.com/giay-adidas-42-den.jpg" }
//      ]
//    }
//  ]
//}