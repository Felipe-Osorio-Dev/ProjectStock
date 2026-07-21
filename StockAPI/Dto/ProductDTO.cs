namespace StockAPI.Dto
{
    public record ProductDTO(string Name, string EAN, int Amount, DateOnly Validate);
}
