using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly ProductCategoryService _service;

        public ProductCategoryController(ProductCategoryService service)
        {
            _service = service;
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] ProductCategory category)
        {
            try
            {
                return Ok(_service.Save(category));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] ProductCategory category)
        {
            try
            {
                return Ok(_service.Update(category));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("")]
        public IActionResult Delete([FromBody] Guid productGuid)
        {
            try
            {
                return Ok(_service.Delete(productGuid));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("")]
        public IActionResult GetALl()
        {
            try
            {
                return Ok(_service.GetAll());
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
                return Ok(_service.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
