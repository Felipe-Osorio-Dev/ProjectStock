using Microsoft.AspNetCore.Mvc;
using StockAPI.Dto;
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
        [HttpPost("/register")]
        public async Task<IActionResult> RegisterProductAsync([FromBody] ProductDTO product)
        {
            var result = await _service.RegisterProductAsync(product);

            if(!result.IsSuccess)
            {
                return Conflict(result.Error);
            }

            return Created();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{ean}")]
        public async Task<ActionResult<string>> DeleteProductByEanAsync(string ean)
        {
            var result = await _service.DeleteProductByEanAsync(ean);

            if(!result.IsSuccess)
            {
                return NotFound(result.Error);
            }

            return result.Value;
        }
    }
}
