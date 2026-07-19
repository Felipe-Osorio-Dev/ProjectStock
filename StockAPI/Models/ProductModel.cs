using Microsoft.EntityFrameworkCore;

namespace StockAPI.Models
{
    [Index(nameof(EAN), IsUnique = true)]
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EAN { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
        public DateOnly CreateAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public bool IsEnable { get; set; } = false;
    }
}
