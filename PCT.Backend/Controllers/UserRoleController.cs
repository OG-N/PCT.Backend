using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly UserRoleService _userRoleService;

        public UserRoleController(UserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet("userrole-by-id/{id}")]
        public IActionResult GetUserRoleById(Guid id)
        {
            try
            {
                return Ok(_userRoleService.GetUserRoleById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("userrole-create")]
        public IActionResult CreateUserRole([FromBody] UserRole userRole)
        {
            try
            {
                return Ok(_userRoleService.CreateUserRole(userRole));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("userrole-create-batch")]
        public IActionResult CreateUserRoles([FromBody] List<UserRole> userRoles)
        {
            try
            {
                return Ok(_userRoleService.CreateUserRoles(userRoles));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("userrole-update")]
        public IActionResult UpdateUserRole([FromBody] UserRole userRole)
        {
            try
            {
                return Ok(_userRoleService.UpdateUserRole(userRole));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("userrole-update-batch")]
        public IActionResult UpdateUserRoles([FromBody] List<UserRole> userRoles)
        {
            try
            {
                return Ok(_userRoleService.UpdateUserRoles(userRoles));
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("userrole-all")]
        public IActionResult GetAllUserRoles()
        {
            try
            {
                return Ok(_userRoleService.GetAllUserRoles());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("userrole-by-user/{userId}")]
        public IActionResult GetAllUserRolesByUser(Guid userId)
        {
            try
            {
                return Ok(_userRoleService.GetAllUserRolesByUser(userId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("userrole-by-role/{roleId}")]
        public IActionResult GetAllUserRolesByRole(Guid roleId)
        {
            try
            {
                return Ok(_userRoleService.GetAllUserRolesByRole(roleId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("userrole-delete/{id}")]
        public IActionResult DeleteUserRole(Guid id)
        {
            try
            {
                return Ok(_userRoleService.DeleteUserRole(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
