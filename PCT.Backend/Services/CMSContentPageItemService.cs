using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class CMSContentPageItemService
    {
        private readonly CMSContentPageItemRepository _repository;

        public CMSContentPageItemService(CMSContentPageItemRepository cmsContentPageItemRepository)
        {
            _repository = cmsContentPageItemRepository;
        }

        public IEnumerable<CMSContentPageItem> GetCmsContentsPageItem()
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
        public IEnumerable<CMSContentPageItem> GetContentPageItemBySectionId(string Section_Id)
        {
            try
            {
                return _repository.GetContentPageItemBySectionId(Section_Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPageItem> GetContentPageItemById(string Id)
        {
            try
            {
                return _repository.GetContentPageItemById(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPageItem> GetContentPageItemByRol(string roleId)
        {
            try
            {
                return _repository.GetContentPageItemByRol(roleId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<CMSContentPageItem> GetContentPageItemByName(string name)
        {
            try
            {
                return _repository.GetContentPageItemByName(name);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CMSContentPageItem NewContent(CMSContentPageItem content)
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
        public CMSContentPageItem UpdateContent(CMSContentPageItem content)
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
                return _repository.UpdateContentPageItemOrder(OrderObjects);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
