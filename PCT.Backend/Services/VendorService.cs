using PCT.Backend.Entities;
using PCT.Backend.Repository;
using PCT.Backend.Utils;

namespace PCT.Backend.Services
{
    public class VendorService
    {
        private readonly VendorRepository _repository;
        public VendorService(VendorRepository repository)
        {
            _repository = repository;
        }

        public Vendor Save(Vendor vendor)
        {
            try
            {
                return _repository.Create(vendor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Vendor Update(Vendor vendor)
        {
            try
            {
                return _repository.Update(vendor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Vendor> GetAll()
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
                Vendor vendor = _repository.GetById(id);
                vendor.IsDeleted = true;
                _repository.Update(vendor);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Vendor GetById(Guid id)
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
