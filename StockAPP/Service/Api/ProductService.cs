using StockAPP.DTO.Requests;
using StockAPP.DTO.Responses;
using StockAPP.Util;
using System.Net.Http.Json;

namespace StockAPP.Service.Api
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Result<List<ProductResponseDTO>>> LoadProductsAsync()
        {
            var response = await _httpClient.GetAsync("");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<ApiErrorResponseDTO>();
                return Result<List<ProductResponseDTO>>.Failure(error?.message ?? "Requisição sem sucesso.");
            }

            var data = await response.Content.ReadFromJsonAsync<List<ProductResponseDTO>>();

            return Result<List<ProductResponseDTO>>.Success(data ?? new List<ProductResponseDTO>());
        }

        public async Task<Result<ProductResponseDTO>> RegisterProductAsync(RegisterProductDTO product)
        {
            var response = await _httpClient.PostAsJsonAsync("", product);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<ApiErrorResponseDTO>();

                return Result<ProductResponseDTO>.Failure(error?.message ?? "Requisição sem sucesso.");
            }

            var data = await response.Content.ReadFromJsonAsync<ProductResponseDTO>();

            if(data == null)
            {
                return Result<ProductResponseDTO>.Failure("A api retornou uma resposta vazia.");
            }

            return Result<ProductResponseDTO>.Success(data);
        }
    }
}
