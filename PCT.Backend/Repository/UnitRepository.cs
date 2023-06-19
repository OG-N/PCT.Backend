using PCT.Backend.Entities;
using PCT.Backened;
using PCT.Backened.Repository;

namespace PCT.Backend.Repository
{
    public class UnitRepository : Repository<Unit>
    {
        public UnitRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
