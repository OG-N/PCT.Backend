using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("user-by-id/{id}")]
        public IActionResult GetUserById(Guid id)
        {
            try
            {
                return Ok(_userService.GetUserById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("user-create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                return Ok(_userService.CreateUser(user));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("user-batch")]
        public IActionResult CreateUsers([FromBody] List<User> users)
        {
            try
            {
                return Ok(_userService.CreateUsers(users));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("user-update")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            try
            {
                return Ok(_userService.UpdateUser(user));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("user-all")]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userService.GetAllUsers());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("user-delete/{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            try
            {
                return Ok(_userService.DeleteUser(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
