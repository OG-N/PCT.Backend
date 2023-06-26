using PCT.Backend.Entities;
using PCT.Backend;
using PCT.Backend.Repository;

namespace PCT.Backend.Repository
{
    public class LocationRepository: Repository<Location>
    {
        public LocationRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
