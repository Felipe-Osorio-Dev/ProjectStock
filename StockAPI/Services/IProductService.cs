using StockAPI.Common;
using StockAPI.Dto;

namespace StockAPI.Services
{
    public interface IProductService
    {
        Task<Result<ProductDTO>> RegisterProductAsync(ProductDTO product);
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    }
}
