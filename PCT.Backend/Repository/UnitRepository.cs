using PCT.Backend.Entities;
using PCT.Backend;
using PCT.Backend.Repository;

namespace PCT.Backend.Repository
{
    public class UnitRepository : Repository<Unit>
    {
        public UnitRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
