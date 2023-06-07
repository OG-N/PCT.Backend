using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductUnitController : ControllerBase
    {
        private readonly ProductUnitService _service;

        public ProductUnitController(ProductUnitService service)
        {
            _service = service;
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] ProductUnit category)
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
        public IActionResult Update([FromBody] ProductUnit category)
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
