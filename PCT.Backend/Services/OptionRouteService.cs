using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class OptionRouteService
    {
        private readonly OptionRouteRepository _repository;

        public OptionRouteService(OptionRouteRepository repository)
        {
            _repository = repository;
        }

        public OptionRoute GetOptionRouteById(Guid id)
        {
            return _repository.GetOptionRouteById(id).FirstOrDefault();
        }
        public IEnumerable<OptionRoute> GetOptionRoutesByUserId(Guid id)
        {            
            try
            {                
                return _repository.GetOptionRoutesByUserId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }        

        public OptionRoute CreateOptionRoute(OptionRoute optionRoute)
        {
            try
            {
                return _repository.Create(optionRoute);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<OptionRoute> CreateOptionRoutes(IEnumerable<OptionRoute> optionRoutes)
        {
            List<OptionRoute> savedOptionRoutes = new List<OptionRoute>();
            try
            {
                foreach (var optionRoute in optionRoutes)
                {
                    savedOptionRoutes.Add(_repository.Create(optionRoute));
                }

                return savedOptionRoutes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OptionRoute UpdateOptionRoute(OptionRoute optionRoute)
        {
            try
            {
                return _repository.Update(optionRoute);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<OptionRoute> UpdateOptionRoutes(IEnumerable<OptionRoute> optionRoutes)
        {
            List<OptionRoute> savedOptionRoutes = new List<OptionRoute>();
            try
            {
                foreach (var optionRoute in optionRoutes)
                {
                    savedOptionRoutes.Add(_repository.Update(optionRoute));
                }

                return savedOptionRoutes;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public IEnumerable<OptionRoute> GetAllOptionRoutes()
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

        public string DeleteOptionRoute(Guid id)
        {
            try
            {
                OptionRoute optionRoute = _repository.GetById(id);

                if (optionRoute.IsDeleted == true)
                {
                    optionRoute.IsDeleted = false;
                    _repository.Update(optionRoute);
                    return "OptionRoute enabled successfully";
                }
                else if (optionRoute.IsDeleted == false)
                {
                    optionRoute.IsDeleted = true;
                    _repository.Update(optionRoute);
                    return "OptionRoute disabled successfully";
                }
                else
                {
                    // Handle any other status values if needed
                    return "Invalid OptionRoute status";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
