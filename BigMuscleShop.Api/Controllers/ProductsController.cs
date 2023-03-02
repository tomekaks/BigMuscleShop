using BigMuscleShop.Application.Contracts.Services;
using BigMuscleShop.Application.Dtos.Product;
using BigMuscleShop.Core.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BigMuscleShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productsService.GetAllProducts();

            return Ok(products);
        }
        

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _productsService.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task AddProduct([FromBody] ProductDto productDto)
        {
            await _productsService.AddProduct(productDto);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto productDto)
        {
            await _productsService.UpdateProduct(productDto);

            return NoContent();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productsService.DeleteProduct(id);

            return NoContent();
        }
    }
}
