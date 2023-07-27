using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class CMSContentImpactService 
    {
        private readonly CMSContentImpactRepository _repository;
        public CMSContentImpactService(CMSContentImpactRepository cmsContentImpactRepository)
        {
            _repository = cmsContentImpactRepository;
        }

        public IEnumerable<CMSContentImpact> GetCmsContentsImpact()
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
        public IEnumerable<CMSContentImpact> GetContentImpactById(string Id)
        {
            try
            {
                return _repository.GetContentImpactById(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentImpact> GetContentImpactByRol(string roleId)
        {
            try
            {
                return _repository.GetContentImpactByRol(roleId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentImpact> GetContentImpactByName(string name)
        {
            try
            {
                return _repository.GetContentImpactByName(name);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CMSContentImpact NewContent(CMSContentImpact content)
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
        public CMSContentImpact UpdateContent(CMSContentImpact content)
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
