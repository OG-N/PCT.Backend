using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using PCT.Backend.Entities;
using PCT.Backend.Repository;
using PCT.Backend.Utils;

namespace PCT.Backend.Services
{
    public class LocationService
    {
        private readonly LocationRepository _repository;
        public LocationService(LocationRepository repository)
        {
            _repository = repository;
        }

        public Location Save(Location location)
        {
            try
            {
                Location l = _repository.Create(location);
                MiddlewareAdapter.PostLocationToMiddleWare(l);
                return l;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Location Update(Location location)
        {
            try
            {
                return _repository.Update(location);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Location> GetAll()
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
                Location location = _repository.GetById(id);
                location.IsDeleted = true;
                _repository.Update(location);
                return "Deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Location GetById(Guid id)
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
