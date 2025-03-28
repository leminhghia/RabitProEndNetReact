using Backend.DTOs;
using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class DanhMucController(DanhMucRepository danhMucRepository) : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var danhMuc = await danhMucRepository.GetAllDanhMucAsync();

            var danhMucDto = danhMuc.Select(x => new DanhMucDto
            {
                DanhMucId = x.DanhMucId,
                TenDanhMuc = x.TenDanhMuc,
                NgayTao = x.NgayTao,
                NgaySua = x.NgaySua,
                IsActived = x.IsActived,
            }).ToList();

            return Ok(danhMucDto);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] DanhMucDto dto)
        {
            var danhMuc = new DanhMuc
            {
                TenDanhMuc = dto.TenDanhMuc,
                NgayTao = DateTime.UtcNow,
                NgaySua = DateTime.UtcNow,
            };
            await danhMucRepository.AddAsync(danhMuc);

            var result = new DanhMucDto
            {
                DanhMucId = danhMuc.DanhMucId,
                TenDanhMuc = danhMuc.TenDanhMuc,
                NgayTao = danhMuc.NgayTao,
                NgaySua = danhMuc.NgaySua
            };
            return Ok(result);
        }
    }
}
