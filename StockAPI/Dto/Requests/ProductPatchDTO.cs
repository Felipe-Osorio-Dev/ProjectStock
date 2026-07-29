namespace StockAPI.Dto.Requests
{
    public class ProductPatchDTO
    {
        public string? Name { get; set; }
        public string? EAN { get; set; }
        public int? Amount { get; set; }
        public DateOnly? Validate { get; set; }
    }
}
