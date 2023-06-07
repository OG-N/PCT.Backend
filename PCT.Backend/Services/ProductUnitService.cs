using Microsoft.EntityFrameworkCore;
using PCT.Backend.Entities;
using PCT.Backend.Repository;

namespace PCT.Backend.Services
{
    public class ProductUnitService
    {
        private readonly ProductUnitRepository _repository;
        public ProductUnitService(ProductUnitRepository repository)
        {
            _repository = repository;
        }

        public ProductUnit Save(ProductUnit productUnit)
        {
            try
            {
                return _repository.Create(productUnit);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductUnit Update(ProductUnit productUnit)
        {
            try
            {
                return _repository.Update(productUnit);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ProductUnit> GetAll()
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
                ProductUnit productUnit = _repository.GetById(id);
                productUnit.IsDeleted = true;
                _repository.Update(productUnit);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductUnit GetById(Guid id)
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
    }
}
