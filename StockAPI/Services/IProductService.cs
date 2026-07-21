using StockAPI.Dto;

namespace StockAPI.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO?> GetProductByIdAsync(long id);
        Task<ProductDTO?> GetProductByEANAsync(string EAN);
        Task RegisterProductAsync(ProductDTO product);
    }
}
