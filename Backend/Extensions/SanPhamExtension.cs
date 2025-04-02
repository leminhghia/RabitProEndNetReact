using Backend.Models;

namespace Backend.Extensions
{
    public static class SanPhamExtension
    {
        public static IQueryable<SanPham> Sort(this IQueryable<SanPham> query, string? orderBy, string? sort)
        {

            sort = sort?.ToLower() ?? "asc";

            switch(orderBy?.ToLower())
            {
                case "price":
                    query = sort == "desc" 
                        ? query.OrderByDescending(x=>x.GiaGoc)
                        : query.OrderBy(x=>x.GiaGoc);
                break;              
            }
            return query;
        }

        public static IQueryable<SanPham> Search(this IQueryable<SanPham> query, string? searchItem)
        {
            if (string.IsNullOrEmpty(searchItem)) return query;
            
            var lowerCaseChar = searchItem.Trim().ToLower();

            return query.Where(x=>x.TenSanPham.ToLower().Contains(lowerCaseChar));

        }

        public static IQueryable<SanPham> Filter(this IQueryable<SanPham> query, List<int>? thuongHieuId, List<int>? danhMucId)
        {
            if (thuongHieuId != null && thuongHieuId.Any())
            {
                query = query.Where(sp => sp.ThuongHieu_SanPham
                    .Any(th => thuongHieuId.Contains(th.ThuongHieuId)));
            }

            if (danhMucId != null && danhMucId.Any())
            {
                query = query.Where(sp => sp.DanhMuc_SanPham
                    .Any(dm => danhMucId.Contains(dm.DanhMucId)));
            }
            return query;
        }
            

    }
}
