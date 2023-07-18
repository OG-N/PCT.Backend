using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class CMSContentPageSectionService
    {
        private readonly CMSContentPageSectionRepository _repository;

        public CMSContentPageSectionService(CMSContentPageSectionRepository cmsContentPageSectionRepository)
        {
            _repository = cmsContentPageSectionRepository;
        }

        public IEnumerable<CMSContentPageSection> GetCmsContentsPageSection()
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
        public IEnumerable<CMSContentPageSection> GetContentPageSectionByPageId(string Page_Id)
        {
            try
            {
                return _repository.GetContentPageSectionByPageId(Page_Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPageSection> GetContentPageSectionById(string Id)
        {
            try
            {
                return _repository.GetContentPageSectionById(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPageSection> GetContentPageSectionByRol(string roleId)
        {
            try
            {
                return _repository.GetContentPageSectionByRol(roleId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPageSection> GetContentPageSectionByName(string name)
        {
            try
            {
                return _repository.GetContentPageSectionByName(name);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CMSContentPageSection NewContent(CMSContentPageSection content)
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
        public CMSContentPageSection UpdateContent(CMSContentPageSection content)
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
                return _repository.UpdateContentPageSectionOrder(OrderObjects);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
