using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class CMSContentLeadershipService 
    {
        private readonly CMSContentLeadershipRepository _repository;

        public CMSContentLeadershipService(CMSContentLeadershipRepository cmsContentLeadershipRepository)
        {
            _repository = cmsContentLeadershipRepository;
        }

        public IEnumerable<CMSContentLeadership> GetCmsContentsLeadership()
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
        public IEnumerable<CMSContentLeadership> GetContentLeadershipById(string Id)
        {
            try
            {
                return _repository.GetContentLeadershipById(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentLeadership> GetContentLeadershipByRol(string roleId)
        {
            try
            {
                return _repository.GetContentLeadershipByRol(roleId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentLeadership> GetContentLeadershipByName(string name)
        {
            try
            {
                return _repository.GetContentLeadershipByName(name);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public CMSContentLeadership NewContent(CMSContentLeadership content)
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
        public CMSContentLeadership UpdateContent(CMSContentLeadership content)
        {
            try
            {
                return _repository.Update(content);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
