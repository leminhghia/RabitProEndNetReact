using Backend.DTOs;
using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class ThuongHieuController(ThuongHieuRepository thuongHieuRepository) : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var danhMuc = await thuongHieuRepository.GetAllThuongHieu();

            var danhMucDto = danhMuc.Select(x => new ThuongHieuDto
            {
                ThuongHieuId = x.ThuongHieuId,
                TenThuongHieu = x.TenThuongHieu,
                NgayTao = x.NgayTao,
                NgaySua = x.NgaySua,
                IsActived = x.IsActived,
            }).ToList();

            return Ok(danhMucDto);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ThuongHieuDto dto)
        {
            var thuongHieu = new ThuongHieu
            {
                TenThuongHieu = dto.TenThuongHieu,
                NgayTao = DateTime.UtcNow,
                NgaySua = DateTime.UtcNow,
            };
            await thuongHieuRepository.AddAsync(thuongHieu);

     
            return Ok(thuongHieu);
        }
    }
}
