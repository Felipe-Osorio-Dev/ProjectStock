namespace StockAPP.DTO.Requests
{
    public class RegisterProductDTO
    {
        public string Name { get; set; }
        public string EAN { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
    }
}
