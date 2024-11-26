using DAL.Repositories.Role;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Role
{
    public class RoleService : IRoleService
    {
        public readonly IRoleRepository _repository;
        public RoleService(IRoleRepository repository)
        {
            this._repository = repository;
        }
        public List<VaiTro> GetRoleList()
        {
            return _repository.GetRoleList();
        }
    }
    
}
