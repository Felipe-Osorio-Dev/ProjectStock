using Microsoft.EntityFrameworkCore;
using StockAPI.AppData;
using StockAPI.Models;

namespace StockAPI.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteProductByIdAsync(ProductModel model)
        {
            _dbContext.Produtos.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return await _dbContext.Produtos.ToListAsync();
        }

        public async Task<ProductModel?> GetProductByIdAsync(long id)
        { 
            return await _dbContext.Produtos.FindAsync(id);
        }

        public async Task RegisterProductAsync(ProductModel model)
        {
            await _dbContext.Produtos.AddAsync(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
