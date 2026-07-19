using Microsoft.EntityFrameworkCore;
using StockAPI.Models;

namespace StockAPI.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<ProductModel> Produtos { get; set; }
    }
}
