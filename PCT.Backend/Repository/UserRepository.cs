using PCT.Backened.Entities;

namespace PCT.Backened.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<User> GetUserById(Guid id)
        {
            return _dataContext.Users.Where(u => u.Id == id && u.IsDeleted == false);
        }

    }
}
