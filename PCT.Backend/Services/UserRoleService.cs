using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class UserRoleService
    {
        private readonly UserRoleRepository _repository;

        public UserRoleService(UserRoleRepository repository)
        {
            _repository = repository;
        }

        public UserRole GetUserRoleById(Guid id)
        {
            return _repository.GetUserRoleById(id).FirstOrDefault();
        }

        public UserRole CreateUserRole(UserRole userRole)
        {
            try
            {
                return _repository.Create(userRole);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<UserRole> CreateUserRoles(IEnumerable<UserRole> userRoles)
        {
            List<UserRole> savedUserRoles = new List<UserRole>();
            try
            {
                foreach (var userRole in userRoles)
                {
                    savedUserRoles.Add(_repository.Create(userRole));
                }

                return savedUserRoles;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserRole UpdateUserRole(UserRole userRole)
        {
            try
            {
                return _repository.Update(userRole);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<UserRole> UpdateUserRoles(IEnumerable<UserRole> userRoles)
        {
            List<UserRole> savedUserRoles = new List<UserRole>();
            try
            {
                foreach (var userRole in userRoles)
                {
                    savedUserRoles.Add(_repository.Update(userRole));
                }

                return savedUserRoles;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<UserRole> GetAllUserRoles()
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

        public IEnumerable<UserRole> GetAllUserRolesByUser(Guid UserId)
        {
            try
            {
                return _repository.GetAll().Where(x => x.UserId == UserId && x.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<UserRole> GetAllUserRolesByRole(Guid RoleId)
        {
            try
            {
                return _repository.GetAll().Where(x => x.RoleId == RoleId && x.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DeleteUserRole(Guid id)
        {
            try
            {
                UserRole userRole = _repository.GetById(id);

                if (userRole.IsDeleted == true)
                {
                    userRole.IsDeleted = false;
                    _repository.Update(userRole);
                    return "UserRole enabled successfully";
                }
                else if (userRole.IsDeleted == false)
                {
                    userRole.IsDeleted = true;
                    _repository.Update(userRole);
                    return "UserRole disabled successfully";
                }
                else
                {
                    // Handle any other status values if needed
                    return "Invalid UserRole status";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
