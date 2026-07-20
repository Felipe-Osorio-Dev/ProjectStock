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

        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return await _dbContext.Produtos.ToListAsync();
        }

        public async Task<ProductModel?> GetProductByEANAsync(string EAN)
        { 
            return await _dbContext.Produtos.FirstOrDefaultAsync(p => p.EAN == EAN);
        }

        public async Task<ProductModel?> GetProductByIdAsync(long id)
        {
            return await _dbContext.Produtos.FindAsync(id);
        }

        public async Task RegisterProductAsync(ProductModel product)
        {
            await _dbContext.Produtos.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
