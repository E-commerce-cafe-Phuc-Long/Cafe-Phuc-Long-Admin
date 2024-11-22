using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Role
{
    public class RoleRepository: IRoleRepository
    {

        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public RoleRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<VaiTro> GetRoleList()
        {
            return _context.VaiTros.ToList();
        }
    }
}
