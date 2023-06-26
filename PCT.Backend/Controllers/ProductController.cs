using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;
using PCT.Backend.Utils;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly IConfiguration _configuration;
        private readonly MiddlewareAdapter _middlewareAdapter;

        public ProductController(ProductService productService, IConfiguration configuration)
        {
            _productService = productService;
            _configuration = configuration;
            _middlewareAdapter = new MiddlewareAdapter(_configuration);
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                Product p = _productService.SaveProduct(product);
                _middlewareAdapter.PostProductToMiddleWare(p);
                return Ok(p);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            try
            {
                _productService.UpdateProduct(product);
                return Ok(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                return Ok(_productService.Delete(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("approve")]
        public IActionResult ApproveProduct([FromBody] Guid productGuid)
        {
            try
            {
                Product product = _productService.GetProductByUuid(productGuid);
                product.Status = Status.Approved;
                return Ok(_productService.UpdateProduct(product));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("products")]
        public IActionResult AddProducts(List<Product> products)
        {
            try
            {
                return Ok(_productService.SaveProducts(products));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("")]
        public IActionResult GetProducts()
        {
            try
            {
                return Ok(_productService.GetProducts());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("product-by-id")]
        public IActionResult GetProductByUuid(Guid id)
        {
            try
            {
                return Ok(_productService.GetProductByUuid(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("products-by-category")]
        public IActionResult GetProductByCategory(Guid CategoryId)
        {
            try
            {
                return Ok(_productService.GetProductByCategoryId(CategoryId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_productService.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
