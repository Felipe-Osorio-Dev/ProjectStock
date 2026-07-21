using MapsterMapper;
using StockAPI.Dto;
using StockAPI.Models;
using StockAPI.Repositorys;

namespace StockAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            return _mapper.Map<List<ProductDTO>>(_repository.GetAllProductsAsync());
        }

        public async Task<ProductDTO?> GetProductByEANAsync(string EAN)
        {
            var product = _repository.GetProductByEANAsync(EAN);

            if (product == null)
            {
                return null;
            }

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO?> GetProductByIdAsync(long id)
        {
            var product = _repository.GetProductByIdAsync(id);

            if (product == null)
            {
                return null;
            }

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task RegisterProductAsync(ProductDTO product)
        {
            var model = _mapper.Map<ProductModel>(product);

            await _repository.RegisterProductAsync(model);
        }
    }
}
