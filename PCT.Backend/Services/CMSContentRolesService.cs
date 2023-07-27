using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class CMSContentRolesService
    {
        private readonly CMSContentRolesRepository _repository;

        public CMSContentRolesService(CMSContentRolesRepository cmsContentRolesRepository)
        {
            _repository = cmsContentRolesRepository;
        }

        public IEnumerable<CMSContentRoles> GetCmsContentsRoles()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<CMSContentRoles_dataQ> GetCmsContentsRolesByID(string Id_content, string Type)
        {
            try
            {
                return _repository.GetRolesByID(Id_content,Type);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CMSContentRoles NewContent(CMSContentRoles content)
        {
            try
            {
                return _repository.Create(content);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
