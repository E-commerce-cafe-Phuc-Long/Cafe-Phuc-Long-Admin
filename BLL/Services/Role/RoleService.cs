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
      
     

      
        public bool Insert(VaiTro p)
        { return _repository.Insert(p); }
        public bool Update(VaiTro updated)
        { return _repository.Update(updated); }
        public bool Delete(string maVaiTro)
        { return _repository.Delete(maVaiTro); }

    }
    
}
