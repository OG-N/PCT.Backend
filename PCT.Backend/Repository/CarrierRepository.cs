using PCT.Backend.Entities;
using PCT.Backend;
using PCT.Backend.Repository;

namespace PCT.Backend.Repository
{
    public class CarrierRepository : Repository<Carrier>
    {
        public CarrierRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
