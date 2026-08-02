using StockAPI.Common;
using StockAPI.Dto.Requests;
using StockAPI.Dto.Responses;

namespace StockAPI.Services
{
    public interface IProductService
    {
        Task<Result<ProductResponseDTO>> RegisterProductAsync(CreateProductDTO product);
        Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync();
        Task<Result<ProductResponseDTO>> GetProductByIdAsync(long id);
        Task<Result> DeleteProductByIdAsync(long id);
        Task<Result<ProductResponseDTO>> UpdateProductAsync(long id, ProductPatchDTO product);
    }
}
