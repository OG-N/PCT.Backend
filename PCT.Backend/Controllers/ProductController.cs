using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                _productService.SaveProduct(product);
                return Ok(product);
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

        [HttpDelete("")]
        public IActionResult DeleteProduct([FromBody] Guid productGuid)
        {
            try
            {
                _productService.GetProductByUuid(productGuid);
                return Ok(_productService.Delete(productGuid));
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
                product.Status = ProductStatus.Approved;
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
    }
}
