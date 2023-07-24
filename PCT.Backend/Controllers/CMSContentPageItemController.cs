using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSContentPageItemController : ControllerBase
    {
        private readonly CMSContentPageItemService _cmsContentPageItemService;

        public CMSContentPageItemController(CMSContentPageItemService cmsContentPageItemService)
        {
            _cmsContentPageItemService = cmsContentPageItemService;
        }

        [HttpPost]
        public IActionResult NewCMSContentPageItem([FromBody] CMSContentPageItem cmsContentPageItem)
        {
            try
            {
                _cmsContentPageItemService.NewContent(cmsContentPageItem);
                return Ok(cmsContentPageItem);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost("updateContent")]
        public IActionResult UpdateCMSContentPageItem([FromBody] CMSContentPageItem cmsContentPageItem)
        {
            try
            {
                _cmsContentPageItemService.UpdateContent(cmsContentPageItem);
                return Ok(cmsContentPageItem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("updateOrder")]
        public IActionResult UpdateCMSContentPageItemOrder(object[] cmsContentPageItemOrder)
        {
            try
            {
                _cmsContentPageItemService.UpdateContentOrder(cmsContentPageItemOrder);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetCMSContentsPageItem()
        {
            try
            {
                var cmsContentPageItems = _cmsContentPageItemService.GetCmsContentsPageItem();
                return Ok(cmsContentPageItems);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("contentBySectionId/{Section_Id}")]
        public IActionResult GetCMSContentBySectionId(Guid Section_Id)
        {
            try
            {
                var cmsContentPageItems = _cmsContentPageItemService.GetContentPageItemBySectionId(Section_Id.ToString());
                return Ok(cmsContentPageItems);
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
                var cmsContentPageItems = _cmsContentPageItemService.GetContentPageItemById(Id.ToString());
                return Ok(cmsContentPageItems);
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
                var cmsContentPageItems = _cmsContentPageItemService.GetContentPageItemByRol(Id_rol.ToString());
                return Ok(cmsContentPageItems);
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
                var cmsContentPageItems = _cmsContentPageItemService.GetContentPageItemByName(name);
                return Ok(cmsContentPageItems);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
