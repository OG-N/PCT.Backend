using PCT.Backened.Entities;

namespace PCT.Backened.Repository
{
    public class UserRoleRepository : Repository<UserRole>
    {
        public UserRoleRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public IQueryable<UserRole> GetUserRoleById(Guid id)
        {
            return _dataContext.UserRoles.Where(o => o.Id == id && o.IsDeleted == false);
        }
    }
}
