using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class ThuongHieuRepository : GenericRepository<ThuongHieu>
    {
        private readonly AppDbContext _context;
        public ThuongHieuRepository(AppDbContext context) :base(context) 
        {
            _context = context;
        }
      public async Task<IEnumerable<ThuongHieuDto>> GetAllThuongHieu()
        {
            return await _context.ThuongHieu
                .Select(x => new ThuongHieuDto
                { 
                    ThuongHieuId = x.ThuongHieuId,
                    TenThuongHieu = x.TenThuongHieu,
                    NgayTao = x.NgayTao,
                    NgaySua = x.NgaySua,
                    IsActived = x.IsActived,
                }).ToListAsync();
        } 
}
}
