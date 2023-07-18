using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSContentPageSectionController : ControllerBase
    {
        private readonly CMSContentPageSectionService _cmsContentPageSectionService;

        public CMSContentPageSectionController(CMSContentPageSectionService cmsContentPageSectionService)
        {
            _cmsContentPageSectionService = cmsContentPageSectionService;
        }

        [HttpPost]
        public IActionResult NewCMSContentPageSection([FromBody] CMSContentPageSection cmsContentPageSection)
        {
            try
            {
                _cmsContentPageSectionService.NewContent(cmsContentPageSection);
                return Ok(cmsContentPageSection);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost("updateContent")]
        public IActionResult UpdateCMSContentPageSection([FromBody] CMSContentPageSection cmsContentPageSection)
        {
            try
            {
                _cmsContentPageSectionService.UpdateContent(cmsContentPageSection);
                return Ok(cmsContentPageSection);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("updateOrder")]
        public IActionResult UpdateCMSContentPageSectionOrder(object[] cmsContentPageSectionOrder)
        {
            try
            {
                _cmsContentPageSectionService.UpdateContentOrder(cmsContentPageSectionOrder);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetCMSContentsPageSection()
        {
            try
            {
                var cmsContentPageSections = _cmsContentPageSectionService.GetCmsContentsPageSection();
                return Ok(cmsContentPageSections);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("contentByPageId/{Page_Id}")]
        public IActionResult GetCMSContentByPageId(Guid Page_Id)
        {
            try
            {
                var cmsContentPageSections = _cmsContentPageSectionService.GetContentPageSectionByPageId(Page_Id.ToString());
                return Ok(cmsContentPageSections);
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
                var cmsContentPageSections = _cmsContentPageSectionService.GetContentPageSectionById(Id.ToString());
                return Ok(cmsContentPageSections);
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
                var cmsContentPageSections = _cmsContentPageSectionService.GetContentPageSectionByRol(Id_rol.ToString());
                return Ok(cmsContentPageSections);
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
                var cmsContentPageSections = _cmsContentPageSectionService.GetContentPageSectionByName(name);
                return Ok(cmsContentPageSections);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
