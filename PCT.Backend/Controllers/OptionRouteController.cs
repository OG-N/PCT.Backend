using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionRouteController : ControllerBase
    {
        private readonly OptionRouteService _optionRouteService;

        public OptionRouteController(OptionRouteService optionRouteService)
        {
            _optionRouteService = optionRouteService;
        }

        [HttpGet("optionroute-by-id/{id}")]
        public IActionResult GetOptionRouteById(Guid id)
        {
            try
            {
                return Ok(_optionRouteService.GetOptionRouteById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("optionroute-by-userid/{id}")]
        public IActionResult GetOptionRoutesByUserId(Guid id)
        {
            try
            {
                return Ok(_optionRouteService.GetOptionRoutesByUserId(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("optionroute-create")]
        public IActionResult CreateOptionRoute([FromBody] OptionRoute optionRoute)
        {
            try
            {
                return Ok(_optionRouteService.CreateOptionRoute(optionRoute));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("optionroute-create-batch")]
        public IActionResult CreateOptionRoutes([FromBody] List<OptionRoute> optionRoutes)
        {
            try
            {
                return Ok(_optionRouteService.CreateOptionRoutes(optionRoutes));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("optionroute-update")]
        public IActionResult UpdateOptionRoute([FromBody] OptionRoute optionRoute)
        {
            try
            {
                return Ok(_optionRouteService.UpdateOptionRoute(optionRoute));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("optionroute-update-batch")]
        public IActionResult UpdateOptionRoutes([FromBody] List<OptionRoute> optionRoutes)
        {
            try
            {
                return Ok(_optionRouteService.UpdateOptionRoutes(optionRoutes));
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("optionroute-all")]
        public IActionResult GetAllOptionRoutes()
        {
            try
            {
                return Ok(_optionRouteService.GetAllOptionRoutes());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("optionroute-delete/{id}")]
        public IActionResult DeleteOptionRoute(Guid id)
        {
            try
            {
                return Ok(_optionRouteService.DeleteOptionRoute(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
