namespace Backend.RequestHelpers
{
    public class ProductParams : PaginationParams
    {
        public string? OrderBy { get; set; }
        public string? Sort { get; set; }
        public string? SearchItem { get; set; }
        public string? ThuongHieuId { get; set; }
        public string? DanhMucId { get; set; }
    }
}
