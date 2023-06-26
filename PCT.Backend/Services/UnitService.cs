using Microsoft.EntityFrameworkCore;
using PCT.Backend.Entities;
using PCT.Backend.Repository;

namespace PCT.Backend.Services
{
    public class UnitService
    {
        private readonly UnitRepository _repository;
        public UnitService(UnitRepository repository)
        {
            _repository = repository;
        }

        public Unit Save(Unit productUnit)
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

        public Unit Update(Unit productUnit)
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

        public IEnumerable<Unit> GetAll()
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
                Unit productUnit = _repository.GetById(id);
                productUnit.IsDeleted = true;
                _repository.Update(productUnit);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Unit GetById(Guid id)
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

        public IEnumerable<Unit> GetByGroup(Group group)
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
