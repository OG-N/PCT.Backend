using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleOptionController : ControllerBase
    {
        private readonly RoleOptionService _roleOptionService;

        public RoleOptionController(RoleOptionService roleOptionService)
        {
            _roleOptionService = roleOptionService;
        }

        [HttpGet("roleoption-by-id/{id}")]
        public IActionResult GetRoleOptionById(Guid id)
        {
            try
            {
                return Ok(_roleOptionService.GetRoleOptionById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("roleoption-create")]
        public IActionResult CreateRoleOption([FromBody] RoleOption roleOption)
        {
            try
            {
                return Ok(_roleOptionService.CreateRoleOption(roleOption));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("roleoption-create-batch")]
        public IActionResult CreateRoleOptions([FromBody] List<RoleOption> roleOptions)
        {
            try
            {
                return Ok(_roleOptionService.CreateRoleOptions(roleOptions));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("roleoption-update")]
        public IActionResult UpdateRoleOption([FromBody] RoleOption roleOption)
        {
            try
            {
                return Ok(_roleOptionService.UpdateRoleOption(roleOption));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("roleoption-update-batch")]
        public IActionResult UpdateRoleOptions([FromBody] List<RoleOption> roleOptions)
        {
            try
            {
                return Ok(_roleOptionService.UpdateRoleOptions(roleOptions));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("roleoption-all")]
        public IActionResult GetAllRoleOptions()
        {
            try
            {
                return Ok(_roleOptionService.GetAllRoleOptions());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("roleoption-by-role/{roleId}")]
        public IActionResult GetAllRoleOptionsByRole(Guid roleId)
        {
            try
            {
                return Ok(_roleOptionService.GetAllRoleOptionsByRole(roleId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("roleoption-by-option/{optionId}")]
        public IActionResult GetAllRoleOptionsByOption(Guid optionId)
        {
            try
            {
                return Ok(_roleOptionService.GetAllRoleOptionsByOption(optionId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("roleoption-delete/{id}")]
        public IActionResult DeleteRoleOption(Guid id)
        {
            try
            {
                return Ok(_roleOptionService.DeleteRoleOption(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
