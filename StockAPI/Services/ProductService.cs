using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using StockAPI.Common;
using StockAPI.Dto.Requests;
using StockAPI.Dto.Responses;
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

        public async Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync()
        {
            var products = await _repository.GetAllProductsAsync();

            return _mapper.Map<IEnumerable<ProductResponseDTO>>(products);
        }

        public async Task<Result<ProductResponseDTO>> GetProductByIdAsync(long id)
        {
            var model = await _repository.GetProductByIdAsync(id);

            if(model == null)
            {
                return Result<ProductResponseDTO>.Failure("Produto não Encontrado!!");
            }

            var product = _mapper.Map<ProductResponseDTO>(model);

            return Result<ProductResponseDTO>.Success(product);
        }

        public async Task<Result<ProductResponseDTO>> RegisterProductAsync(CreateProductDTO product)
        {
            try
            {
                var model = _mapper.Map<ProductModel>(product);

                await _repository.RegisterProductAsync(model);

                var dto = _mapper.Map<ProductResponseDTO>(model);

                return Result<ProductResponseDTO>.Success(dto);
            }
            catch (DbUpdateException)
            {
                return Result<ProductResponseDTO>.Failure("Produto Ja Cadastrado!!");
            }
        }

        public async Task<Result<ProductResponseDTO>> UpdateProductAsync(long id, ProductPatchDTO product)
        {
            var model = await _repository.GetProductByIdAsync(id);

            if (model == null)
            {
                return Result<ProductResponseDTO>.Failure("Produto não Encontrado!!");
            }

            _mapper.Map(product, model);

            await _repository.UpdateProductAsync();

            var response = _mapper.Map<ProductResponseDTO>(model);

            return Result<ProductResponseDTO>.Success(response);
        }

        public async Task<Result> DeleteProductByIdAsync(long id)
        {
            var model = await _repository.GetProductByIdAsync(id);

            if (model == null)
            {
                return Result.Failure("Produto não Encontrado!!");
            }

            await _repository.DeleteProductByIdAsync(model);

            return Result.Success();
        }
    }
}
