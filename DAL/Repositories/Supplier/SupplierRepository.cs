using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Supplier
{
    public class SupplierRepository:ISupplierRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public SupplierRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<NhaCungCap> GetSupplierList()
        {
            return _context.NhaCungCaps.ToList();
        }


        public bool Insert(NhaCungCap p)
        {
            try
            {
                _context.NhaCungCaps.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string maNCC)
        {
            try
            {
                var kh = _context.NhaCungCaps.SingleOrDefault(p => p.maNCC == maNCC);

                if (kh != null)
                {
                    _context.NhaCungCaps.DeleteOnSubmit(kh);
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
        public bool Update(NhaCungCap updated)
        {
            try
            {
                var nv = _context.NhaCungCaps.SingleOrDefault(p => p.maNCC == updated.maNCC);

                if (nv != null)
                {
                    nv.tenNCC = updated.tenNCC;                  
                    nv.diaChi = updated.diaChi;

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
        public dynamic Search(string keyword)
        {
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    return GetSupplierList();
                }

                var result = _context.NhaCungCaps
                .Where(nv => nv.maNCC.Contains(keyword) ||
                             nv.tenNCC.Contains(keyword))
                   .Select(staff => new
                   {
                       staff.maNCC,
                       staff.tenNCC,
                       staff.diaChi,

                   })
                                   .ToList();

                return result;
            }

            catch
            {
                return new List<NhaCungCap>();
            }
        }


    }
}
