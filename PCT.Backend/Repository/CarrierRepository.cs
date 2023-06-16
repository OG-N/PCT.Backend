using PCT.Backend.Entities;
using PCT.Backened;
using PCT.Backened.Repository;

namespace PCT.Backend.Repository
{
    public class CarrierRepository : Repository<Carrier>
    {
        public CarrierRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
