using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Role
{
    public class RoleRepository : IRoleRepository
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

        public bool Insert(VaiTro p)
        {
            try
            {
                _context.VaiTros.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string maVaiTro)
        {
            try
            {
                var kh = _context.VaiTros.SingleOrDefault(p => p.maVaiTro == maVaiTro);

                if (kh != null)
                {
                    _context.VaiTros.DeleteOnSubmit(kh);
                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(VaiTro updated)
        {
            try
            {
                var nv = _context.VaiTros.SingleOrDefault(p => p.maVaiTro == updated.maVaiTro);

                if (nv != null)
                {
                    nv.tenVaiTro = updated.tenVaiTro;
                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
