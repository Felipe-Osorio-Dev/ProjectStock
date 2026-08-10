using Microsoft.AspNetCore.Mvc;
using StockAPI.Dto.Requests;
using StockAPI.Dto.Responses;
using StockAPI.Services;

namespace StockAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetAllProductsAsync()
        {
            return Ok(await _service.GetAllProductsAsync());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseDTO>> GetProductByIdAsync(long id)
        {
            var result = await _service.GetProductByIdAsync(id);

            if (!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return result.Value;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> RegisterProductAsync([FromBody] CreateProductDTO product)
        {
            var result = await _service.RegisterProductAsync(product);

            if(!result.IsSuccess)
            {
                return Conflict(new ApiErrorResponseDTO(StatusCodes.Status409Conflict, result.Error));
            }

            return CreatedAtAction(nameof(GetProductByIdAsync), new { id = result.Value.Id }, result.Value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ProductResponseDTO>> PutProductAsync(long id, [FromBody] ProductPatchDTO product)
        {
            var result = await _service.UpdateProductAsync(id, product);

            if (!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return result.Value;
        }

        // PATCH api/<ProductController>/5
        [HttpPatch("{id}")]
        public async Task<ActionResult<ProductResponseDTO>> PatchProductAsync(long id, [FromBody] ProductPatchDTO product)
        {
            var result = await _service.UpdateProductAsync(id, product);

            if (!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return result.Value;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductByIdAsync(long id)
        {
            var result = await _service.DeleteProductByIdAsync(id);

            if(!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return NoContent();
        }
    }
}
