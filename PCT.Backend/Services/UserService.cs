using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class UserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public User GetUserById(Guid id)
        {
            return _repository.GetUserById(id).FirstOrDefault();
        }

        public User CreateUser(User user)
        {
            try
            {
                return _repository.Create(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<User> CreateUsers(IEnumerable<User> users)
        {
            List<User> savedUsers = new List<User>();
            try
            {
                foreach (var user in users)
                {
                    savedUsers.Add(_repository.Create(user));
                }

                return savedUsers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User UpdateUser(User user)
        {
            try
            {
                return _repository.Update(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DeleteUser(Guid id)
        {
            try
            {
                User user = _repository.GetById(id);

                if (user.IsDeleted == true)
                {
                    user.IsDeleted = false;
                    _repository.Update(user);
                    return "User enabled successfully";
                }
                else if (user.IsDeleted == false)
                {
                    user.IsDeleted = true;
                    _repository.Update(user);
                    return "User disabled successfully";
                }
                else
                {
                    // Handle any other status values if needed
                    return "Invalid User status";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
