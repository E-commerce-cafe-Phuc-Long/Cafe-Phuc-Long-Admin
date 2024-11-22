using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Staff
{
    public class StaffRepository:IStaffRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public StaffRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<NhanVien> GetStaffList()
        {
            return _context.NhanViens.ToList();
        }


        public bool InsertStaff(NhanVien p)
        {
            try
            {
                _context.NhanViens.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteStaff(string maNV)
        {
            try
            {
                var nv = _context.NhanViens.SingleOrDefault(p => p.maNV == maNV);

                if (nv != null)
                {
                    _context.NhanViens.DeleteOnSubmit(nv);
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
        public bool UpdateStaff(NhanVien updated)
        {
            try
            {
                var nv = _context.NhanViens.SingleOrDefault(p => p.maNV == updated.maNV);

                if (nv != null)
                {
                    nv.tenNV = updated.maNV;
                    nv.username = updated.username;
                    nv.matKhau = updated.matKhau;
                    nv.soDT = updated.soDT;
                    nv.ngaySinh = updated.ngaySinh;
                    nv.diaChi = updated.diaChi;
                    nv.email = updated.email;
                    nv.maVaiTro = updated.maVaiTro;


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

        public List<NhanVien> SearchStaff(string keyword)
        {
            try
            {
                var result = _context.NhanViens
                    .Where(nv => nv.maNV.Contains(keyword) || 
                                 nv.tenNV.Contains(keyword) )
                    .ToList();

                return result;
            }
            catch
            {
                return new List<NhanVien>(); 
            }
        }

    }
}
