using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleService _roleService;

        public RoleController(RoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("role-by-id/{id}")]
        public IActionResult GetRoleById(Guid id)
        {
            try
            {
                return Ok(_roleService.GetRoleById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("role-by-name/{name}")]
        public IActionResult GetRoleByName(string name)
        {
            try
            {
                return Ok(_roleService.GetRoleByName(name));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("role-create")]
        public IActionResult CreateRole([FromBody] Role role)
        {
            try
            {
                return Ok(_roleService.CreateRole(role));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("role-batch")]
        public IActionResult CreateRoles([FromBody] List<Role> roles)
        {
            try
            {
                return Ok(_roleService.CreateRoles(roles));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("role-update")]
        public IActionResult UpdateRole([FromBody] Role role)
        {
            try
            {
                return Ok(_roleService.UpdateRole(role));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("role-all")]
        public IActionResult GetAllRoles()
        {
            try
            {
                return Ok(_roleService.GetAllRoles());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("role-delete/{id}")]
        public IActionResult DeleteRole(Guid id)
        {
            try
            {
                return Ok(_roleService.DeleteRole(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
