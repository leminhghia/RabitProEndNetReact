namespace Backend.Models
{
    public class FlashSale
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MaxQuantity { get; set; }
    }
}
