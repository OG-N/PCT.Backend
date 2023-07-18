using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class CMSContentPageService
    {
        private readonly CMSContentPageRepository _repository;

        public CMSContentPageService(CMSContentPageRepository cmsContentPageRepository)
        {
            _repository = cmsContentPageRepository;
        }

        public IEnumerable<CMSContentPage> GetCmsContentsPage()
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
        public IEnumerable<CMSContentPage> GetContentPageById(string Id)
        {
            try
            {
                return _repository.GetContentPageById(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPage> GetContentPageByRol(string roleId)
        {
            try
            {
                return _repository.GetContentPageByRol(roleId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPage> GetContentPageByName(string name)
        {
            try
            {
                return _repository.GetContentPageByName(name);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CMSContentPage NewContent(CMSContentPage content)
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
        public CMSContentPage UpdateContent(CMSContentPage content)
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
        public int UpdateContentOrder(object[] OrderObjects)
        {
            try
            {
                return _repository.UpdateContentPageOrder(OrderObjects);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
