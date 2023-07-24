using Microsoft.AspNetCore.Mvc;
using PCT.Backened.Entities;
using PCT.Backened.Services;

namespace PCT.Backened.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSContentRolesController : ControllerBase
    {
        private readonly CMSContentRolesService _cmsContentRolesService;

        public CMSContentRolesController(CMSContentRolesService cmsContentRolesService)
        {
            _cmsContentRolesService = cmsContentRolesService;
        }

        [HttpPost]
        public IActionResult NewCMSContentRoles([FromBody] CMSContentRoles cmsContentRoles)
        {
            try
            {
                _cmsContentRolesService.NewContent(cmsContentRoles);
                return Ok(cmsContentRoles);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetCMSContentRoless()
        {
            try
            {
                var cmsContentRoless = _cmsContentRolesService.GetCmsContentsRoles();
                return Ok(cmsContentRoless);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("rolesByid/{Id_content}/{Type}")]
        public IActionResult GetCMSContentRolessByID(Guid Id_content, string Type)
        {
            try
            {
                var cmsContentRoless = _cmsContentRolesService.GetCmsContentsRolesByID(Id_content.ToString(), Type);
                return Ok(cmsContentRoless);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
