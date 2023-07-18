using PCT.Backened.Entities;
using PCT.Backened.Repository;

namespace PCT.Backened.Services
{
    public class RoleOptionService
    {
        private readonly RoleOptionRepository _repository;

        public RoleOptionService(RoleOptionRepository repository)
        {
            _repository = repository;
        }

        public RoleOption GetRoleOptionById(Guid id)
        {
            return _repository.GetRoleOptionById(id).FirstOrDefault();
        }

        public RoleOption CreateRoleOption(RoleOption roleOption)
        {
            try
            {
                return _repository.Create(roleOption);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<RoleOption> CreateRoleOptions(IEnumerable<RoleOption> roleOptions)
        {
            List<RoleOption> savedRoleOptions = new List<RoleOption>();
            try
            {
                foreach (var roleOption in roleOptions)
                {
                    savedRoleOptions.Add(_repository.Create(roleOption));
                }

                return savedRoleOptions;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RoleOption UpdateRoleOption(RoleOption roleOption)
        {
            try
            {
                return _repository.Update(roleOption);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<RoleOption> UpdateRoleOptions(IEnumerable<RoleOption> roleOptions)
        {
            List<RoleOption> savedRoleOptions = new List<RoleOption>();
            try
            {
                foreach (var roleOption in roleOptions)
                {
                    savedRoleOptions.Add(_repository.Update(roleOption));
                }

                return savedRoleOptions;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<RoleOption> GetAllRoleOptions()
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
        public IEnumerable<RoleOption> GetAllRoleOptionsByRole(Guid RoleId)
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
        public IEnumerable<RoleOption> GetAllRoleOptionsByOption(Guid OptionId)
        {
            try
            {
                return _repository.GetAll().Where(x => x.OptionId == OptionId && x.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DeleteRoleOption(Guid id)
        {
            try
            {
                RoleOption roleOption = _repository.GetById(id);

                if (roleOption.IsDeleted == true)
                {
                    roleOption.IsDeleted = false;
                    _repository.Update(roleOption);
                    return "RoleOption enabled successfully";
                }
                else if (roleOption.IsDeleted == false)
                {
                    roleOption.IsDeleted = true;
                    _repository.Update(roleOption);
                    return "RoleOption disabled successfully";
                }
                else
                {
                    // Handle any other status values if needed
                    return "Invalid RoleOption status";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
