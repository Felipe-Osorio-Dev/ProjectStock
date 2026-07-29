using Microsoft.AspNetCore.Mvc;
using StockAPI.Dto;
using StockAPI.Dto.Requests;
using StockAPI.Services;

namespace StockAPI.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProductsAsync()
        {
            return Ok(await _service.GetAllProductsAsync());
        }

        // GET api/<ProductController>/5
        [HttpGet("{ean}")]
        public async Task<ActionResult<ProductDTO>> GetProductByEAN(string ean)
        {
            var result = await _service.GetProductByEanAsync(ean);

            if (!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return result.Value;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> RegisterProductAsync([FromBody] ProductDTO product)
        {
            var result = await _service.RegisterProductAsync(product);

            if(!result.IsSuccess)
            {
                return Conflict(result.Error);
            }

            return CreatedAtAction(nameof(GetProductByEAN), new { ean = result.Value.EAN }, result.Value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{ean}")]
        public async Task<ActionResult> PutProductAsync(string ean, [FromBody] ProductPatchDTO product)
        {
            var result = await _service.UpdateProductAsync(ean, product);

            if (!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return Ok();
        }

        // PATCH api/<ProductController>/5
        [HttpPatch("{ean}")]
        public async Task<ActionResult> PatchProductAsync(string ean, [FromBody] ProductPatchDTO product)
        {
            var result = await _service.UpdateProductAsync(ean, product);

            if (!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{ean}")]
        public async Task<ActionResult> DeleteProductByEanAsync(string ean)
        {
            var result = await _service.DeleteProductByEanAsync(ean);

            if(!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return NoContent();
        }
    }
}
