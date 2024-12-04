using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Role
{
    public interface IRoleService
    {
        List<VaiTro> GetRoleList();
    
        bool Insert(VaiTro p);
        bool Delete(string maVaiTro);
        bool Update(VaiTro updated);
    }
}
