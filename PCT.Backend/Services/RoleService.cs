using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class RoleService
    {
        private readonly RoleRepository _repository;

        public RoleService(RoleRepository repository)
        {
            _repository = repository;
        }

        public Role GetRoleById(Guid id)
        {
            return _repository.GetRoleById(id).FirstOrDefault();
        }
        public Role GetRoleByName(string name)
        {
            return _repository.GetRoleByName(name).FirstOrDefault();
        }

        
        public Role CreateRole(Role role)
        {
            try
            {
                return _repository.Create(role);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Role> CreateRoles(IEnumerable<Role> roles)
        {
            List<Role> savedRoles = new List<Role>();
            try
            {
                foreach (var role in roles)
                {
                    savedRoles.Add(_repository.Create(role));
                }

                return savedRoles;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Role UpdateRole(Role role)
        {
            try
            {
                return _repository.Update(role);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Role> GetAllRoles()
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

        public string DeleteRole(Guid id)
        {
            try
            {
                Role role = _repository.GetById(id);

                if (role.IsDeleted == true)
                {
                    role.IsDeleted = false;
                    _repository.Update(role);
                    return "Role enabled successfully";
                }
                else if (role.IsDeleted == false)
                {
                    role.IsDeleted = true;
                    _repository.Update(role);
                    return "Role disabled successfully";
                }
                else
                {
                    // Handle any other status values if needed
                    return "Invalid Role status";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
