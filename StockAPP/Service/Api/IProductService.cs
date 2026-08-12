using StockAPP.DTO.Requests;
using StockAPP.DTO.Responses;
using StockAPP.Util;

namespace StockAPP.Service.Api
{
    public interface IProductService
    {
        Task<Result<ProductResponseDTO>> RegisterProductAsync(RegisterProductDTO product);
    }
}
