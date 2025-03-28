using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class DanhMucRepository : GenericRepository<DanhMuc>
    {
        private readonly AppDbContext _context;
        public DanhMucRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DanhMucDto>> GetAllDanhMucAsync()
        {
            return await _context.DanhMuc
                .Select(x => new DanhMucDto
                {
                    DanhMucId = x.DanhMucId,
                    TenDanhMuc = x.TenDanhMuc,
                    NgayTao = x.NgayTao,
                    NgaySua = x.NgaySua,
                    IsActived = x.IsActived,
                })
                .ToListAsync();
        }



    }
}
