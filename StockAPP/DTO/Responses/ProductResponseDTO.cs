namespace StockAPP.DTO.Responses
{
    public class ProductResponseDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EAN { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
    }
}
