using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using StockAPI.Common;
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
            var products = await _repository.GetAllProductsAsync();

            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<Result<ProductDTO>> RegisterProductAsync(ProductDTO product)
        {
            try
            {
                var model = _mapper.Map<ProductModel>(product);

                await _repository.RegisterProductAsync(model);

                return Result<ProductDTO>.Success(product);
            }
            catch (DbUpdateException)
            {
                return Result<ProductDTO>.Failure("Produto Ja Cadastrado!!");
            }
        }
    }
}
