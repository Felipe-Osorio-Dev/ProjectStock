using StockAPI.Common;
using StockAPI.Dto;
using StockAPI.Dto.Requests;

namespace StockAPI.Services
{
    public interface IProductService
    {
        Task<Result<ProductDTO>> RegisterProductAsync(ProductDTO product);
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<Result<ProductDTO>> GetProductByEanAsync(string ean);
        Task<Result> DeleteProductByEanAsync(string ean);
        Task<Result<ProductPatchDTO>> UpdateProductAsync(string ean, ProductPatchDTO product);
    }
}
