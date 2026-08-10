namespace StockAPI.Dto.Responses
{
    public sealed record ApiErrorResponseDTO(int statusCode, string message);
}
