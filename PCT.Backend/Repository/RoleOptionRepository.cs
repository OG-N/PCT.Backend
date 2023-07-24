using PCT.Backend;
using PCT.Backend.Repository;
using PCT.Backened.Entities;

namespace PCT.Backened.Repository
{
    public class RoleOptionRepository : Repository<RoleOption>
    {
        public RoleOptionRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<RoleOption> GetRoleOptionById(Guid id)
        {
            return _dataContext.RoleOptions.Where(o => o.Id == id && o.IsDeleted == false);
        }

    }
}
