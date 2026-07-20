using StockAPI.Models;

namespace StockAPI.Repositorys
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel?> GetProductByIdAsync(long id);
        Task<ProductModel?> GetProductByEANAsync(string EAN);
        Task RegisterProductAsync(ProductModel product);
    }
}
