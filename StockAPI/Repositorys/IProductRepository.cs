using StockAPI.Models;

namespace StockAPI.Repositorys
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel?> GetProductByIdAsync(long id);
        Task RegisterProductAsync(ProductModel model);
        Task DeleteProductByIdAsync(ProductModel model);
        Task UpdateProductAsync();
    }
}
