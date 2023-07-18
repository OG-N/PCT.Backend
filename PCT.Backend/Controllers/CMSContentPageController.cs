using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSContentPageController : ControllerBase
    {
        private readonly CMSContentPageService _cmsContentPageService;

        public CMSContentPageController(CMSContentPageService cmsContentPageService)
        {
            _cmsContentPageService = cmsContentPageService;
        }

        [HttpPost]
        public IActionResult NewCMSContentPage([FromBody] CMSContentPage cmsContentPage)
        {
            try
            {
                _cmsContentPageService.NewContent(cmsContentPage);
                return Ok(cmsContentPage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost("updateContent")]
        public IActionResult UpdateCMSContentPage([FromBody] CMSContentPage cmsContentPage)
        {
            try
            {
                _cmsContentPageService.UpdateContent(cmsContentPage);
                return Ok(cmsContentPage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost("updateOrder")]
        public IActionResult UpdateCMSContentPageOrder(object[] cmsContentPageOrder)
        {
            try
            {
                _cmsContentPageService.UpdateContentOrder(cmsContentPageOrder);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetCMSContentsPage()
        {
            try
            {
                var cmsContentPages = _cmsContentPageService.GetCmsContentsPage();
                return Ok(cmsContentPages);
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
                var cmsContentPages = _cmsContentPageService.GetContentPageById(Id.ToString());
                return Ok(cmsContentPages);
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
                var cmsContentPages = _cmsContentPageService.GetContentPageByRol(Id_rol.ToString());
                return Ok(cmsContentPages);
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
                var cmsContentPages = _cmsContentPageService.GetContentPageByName(name);
                return Ok(cmsContentPages);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
