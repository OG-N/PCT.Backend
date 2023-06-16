using PCT.Backend.Entities;
using PCT.Backened;
using PCT.Backened.Repository;

namespace PCT.Backend.Repository
{
    public class LocationRepository: Repository<Location>
    {
        public LocationRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
