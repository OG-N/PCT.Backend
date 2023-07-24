using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;
using PCT.Backend.Utils;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController: ControllerBase
    {
        private readonly VendorService _service;
        private readonly IConfiguration _configuration;
        private readonly MiddlewareAdapter _middlewareAdapter;

        public VendorController(VendorService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
            _middlewareAdapter = new MiddlewareAdapter(_configuration);
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] Vendor vendor)
        {
            try
            {
                Vendor v = _service.Save(vendor);
                _middlewareAdapter.PostVendorToMiddleWare(v);
                return Ok(v);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] Vendor vendor)
        {
            try
            {
                return Ok(_service.Update(vendor));
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

