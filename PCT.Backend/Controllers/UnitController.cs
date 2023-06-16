using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly UnitService _service;

        public UnitController(UnitService service)
        {
            _service = service;
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] Unit unit)
        {
            try
            {
                return Ok(_service.Save(unit));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] Unit unit)
        {
            try
            {
                return Ok(_service.Update(unit));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("")]
        public IActionResult Delete([FromBody] Guid guid)
        {
            try
            {
                return Ok(_service.Delete(guid));
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
