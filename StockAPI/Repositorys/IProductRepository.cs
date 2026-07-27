using StockAPI.Models;

namespace StockAPI.Repositorys
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel?> GetProductByIdAsync(long id);
        Task<ProductModel?> GetProductByEanAsync(string ean);
        Task RegisterProductAsync(ProductModel model);
        Task DeleteProductByEanAsync(ProductModel model);
        Task UpdateProductAsync();
    }
}
