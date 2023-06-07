using PCT.Backend.Entities;
using PCT.Backend.Repository;

namespace PCT.Backend.Services
{
    public class ProductCategoryService
    {
        private readonly ProductCategoryRepository _repository;
        public ProductCategoryService(ProductCategoryRepository repository)
        {
            _repository = repository;
        }

        public ProductCategory Save(ProductCategory productCategory)
        {
            try
            {
                return _repository.Create(productCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductCategory Update(ProductCategory productCategory)
        {
            try
            {
                return _repository.Update(productCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            try
            {
                return _repository.GetAll().Where(x => x.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                ProductCategory productCategory = _repository.GetById(id);
                productCategory.IsDeleted = true;
                _repository.Update(productCategory);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ProductCategory> GetById(Guid id)
        {
            try
            {
                return _repository.GetAll().Where(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
