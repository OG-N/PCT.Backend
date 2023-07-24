using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;
using PCT.Backend.Utils;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierController : ControllerBase
    {
        private readonly CarrierService _service;
        private readonly IConfiguration _configuration;
        private readonly MiddlewareAdapter _middlewareAdapter;

        public CarrierController(CarrierService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
            _middlewareAdapter = new MiddlewareAdapter(_configuration);
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] Carrier carrier)
        {
            try
            {
                Carrier c = _service.Save(carrier);
                _middlewareAdapter.PostCarrierToMiddleWare(c);
                return Ok(c);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] Carrier carrier)
        {
            try
            {
                return Ok(_service.Update(carrier));
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
                return Ok(_service.Delete(id));
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
