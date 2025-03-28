namespace Backend.DTOs
{
    public class DanhMucDto
    {
        public int DanhMucId { get; set; }
        public string TenDanhMuc { get; set; } = string.Empty;
        public DateTime  NgayTao   { get; set; } = DateTime.UtcNow;
        public DateTime? NgaySua { get; set; }
        public byte IsActived { get; set; } = 1;

    }
}
