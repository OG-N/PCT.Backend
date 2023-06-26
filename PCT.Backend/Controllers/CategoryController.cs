using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _service;

        public CategoryController(CategoryService service)
        {
            _service = service;
        }

        [HttpPost("")]
        public IActionResult AddNew([FromBody] Category category)
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
        public IActionResult Update([FromBody] Category category)
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

        [HttpGet("categories-by-group/{groupId}")]
        public IActionResult GetByGroup(int groupId)
        {
            try
            {
                return Ok(_service.GetByGroup((Group)groupId));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
