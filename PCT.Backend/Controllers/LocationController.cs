using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;
using PCT.Backend.Utils;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController:ControllerBase
    {
        private readonly LocationService _service;
        private readonly IConfiguration _configuration;
        private readonly MiddlewareAdapter _middlewareAdapter;

        public LocationController(LocationService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
            _middlewareAdapter = new MiddlewareAdapter(_configuration);
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] Location location)
        {
            try
            {
                Location l = _service.Save(location);
                _middlewareAdapter.PostLocationToMiddleWare(l);
                return Ok(l);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] Location location)
        {
            try
            {
                return Ok(_service.Update(location));
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

