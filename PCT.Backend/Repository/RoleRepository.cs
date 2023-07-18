using PCT.Backened.Entities;

namespace PCT.Backened.Repository
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<Role> GetRoleById(Guid id)
        {
            return _dataContext.Roles.Where(r => r.Id == id && r.IsDeleted == false);
        }
        public IQueryable<Role> GetRoleByName(string name)
        {
            return _dataContext.Roles.Where(r => r.Name == name && r.IsDeleted == false);
        }
        
    }
}
