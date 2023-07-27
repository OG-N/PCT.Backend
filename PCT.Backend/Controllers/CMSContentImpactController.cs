using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSContentImpactController : ControllerBase
    {
        private readonly CMSContentImpactService _cmsContentImpactService;

        public CMSContentImpactController(CMSContentImpactService cmsContentImpactService)
        {
            _cmsContentImpactService = cmsContentImpactService;
        }

        [HttpPost]
        public IActionResult NewCMSContentImpact([FromBody] CMSContentImpact cmsContentImpact)
        {
            try
            {
                _cmsContentImpactService.NewContent(cmsContentImpact);
                return Ok(cmsContentImpact);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost("updateContent")]
        public IActionResult UpdateCMSContentImpact([FromBody] CMSContentImpact cmsContentImpact)
        {
            try
            {
                _cmsContentImpactService.UpdateContent(cmsContentImpact);
                return Ok(cmsContentImpact);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetCMSContentsImpact()
        {
            try
            {
                var cmsContentImpacts = _cmsContentImpactService.GetCmsContentsImpact();
                return Ok(cmsContentImpacts);
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
                var cmsContentImpacts = _cmsContentImpactService.GetContentImpactById(Id.ToString());
                return Ok(cmsContentImpacts);
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
                var cmsContentImpacts = _cmsContentImpactService.GetContentImpactByRol(Id_rol.ToString());
                return Ok(cmsContentImpacts);
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
                var cmsContentImpacts = _cmsContentImpactService.GetContentImpactByName(name);
                return Ok(cmsContentImpacts);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
