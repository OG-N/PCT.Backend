using PCT.Backend.Entities;
using PCT.Backend.Repository;

namespace PCT.Backend.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _repository;
        public CategoryService(CategoryRepository repository)
        {
            _repository = repository;
        }

        public Category Save(Category productCategory)
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

        public Category Update(Category productCategory)
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

        public IEnumerable<Category> GetAll()
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
                Category productCategory = _repository.GetById(id);
                productCategory.IsDeleted = true;
                _repository.Update(productCategory);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Category GetById(Guid id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Category> GetByGroup(Group group)
        {
            try
            {
                return _repository.GetAll().Where(x => x.Group == group && x.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
