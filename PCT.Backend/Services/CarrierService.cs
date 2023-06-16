using PCT.Backend.Entities;
using PCT.Backend.Repository;

namespace PCT.Backend.Services
{
    public class CarrierService
    {
        private readonly CarrierRepository _repository;
        public CarrierService(CarrierRepository repository)
        {
            _repository = repository;
        }

        public Carrier Save(Carrier carrier)
        {
            try
            {
                return _repository.Create(carrier);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrier Update(Carrier carrier)
        {
            try
            {
                return _repository.Update(carrier);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Carrier> GetAll()
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
                Carrier carrier = _repository.GetById(id);
                carrier.IsDeleted = true;
                _repository.Update(carrier);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrier GetById(Guid id)
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
