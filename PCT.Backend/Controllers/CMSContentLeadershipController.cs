using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSContentLeadershipController : ControllerBase
    {
        private readonly CMSContentLeadershipService _cmsContentLeadershipService;

        public CMSContentLeadershipController(CMSContentLeadershipService cmsContentLeadershipService)
        {
            _cmsContentLeadershipService = cmsContentLeadershipService;
        }

        [HttpPost]
        public IActionResult NewCMSContentLeadership([FromBody] CMSContentLeadership cmsContentLeadership)
        {
            try
            {
                _cmsContentLeadershipService.NewContent(cmsContentLeadership);
                return Ok(cmsContentLeadership);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("updateContent")]
        public IActionResult UpdateCMSContentLeadership([FromBody] CMSContentLeadership cmsContentLeadership)
        {
            try
            {
                _cmsContentLeadershipService.UpdateContent(cmsContentLeadership);
                return Ok(cmsContentLeadership);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetCMSContentLeaderships()
        {
            try
            {
                var cmsContentLeaderships = _cmsContentLeadershipService.GetCmsContentsLeadership();
                return Ok(cmsContentLeaderships);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("contentById/{Id}")]
        public IActionResult GetCMSContentById(Guid Id)
        {
            try
            {
                var cmsContentLeaderships = _cmsContentLeadershipService.GetContentLeadershipById(Id.ToString());
                return Ok(cmsContentLeaderships);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("contentByRol/{Id_rol}")]
        public IActionResult GetCMSContentByRol(Guid Id_rol)
        {
            try
            {
                var cmsContentLeaderships = _cmsContentLeadershipService.GetContentLeadershipByRol(Id_rol.ToString());
                return Ok(cmsContentLeaderships);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("contentByName/{name}")]
        public IActionResult GetCMSContentByName(string name)
        {
            try
            {
                var cmsContentLeaderships = _cmsContentLeadershipService.GetContentLeadershipByName(name);
                return Ok(cmsContentLeaderships);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
