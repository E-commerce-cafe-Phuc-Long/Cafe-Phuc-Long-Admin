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
        public dynamic GetStaffWithRoleNames()
        {
            var roleDictionary = _context.VaiTros.ToDictionary(role => role.maVaiTro?.ToString(), role => role.tenVaiTro);

            return _context.NhanViens.Select(staff => new
            {
                staff.maNV,
                staff.username,
                staff.matKhau,
                staff.tenNV,
                staff.ngaySinh,
                staff.soDT,
                staff.diaChi,
                staff.email,
                staff.maVaiTro,

                tenVaiTro = staff.maVaiTro != null && roleDictionary.ContainsKey(staff.maVaiTro.ToString())
                              ? roleDictionary[staff.maVaiTro.ToString()]
                              : null
            }).ToList();
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
        public dynamic SearchStaff(string keyword)
        {
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    return GetStaffWithRoleNames();
                }
                var roleDictionary = _context.VaiTros.ToDictionary(role => role.maVaiTro?.ToString(), role => role.tenVaiTro);

                var result = _context.NhanViens
                        .Where(nv => nv.maNV.Contains(keyword) || 
                                        nv.tenNV.Contains(keyword) )
                        .Select(staff => new
                        {
                            staff.maNV,
                            staff.username,
                            staff.matKhau,
                            staff.tenNV,
                            staff.ngaySinh,
                            staff.soDT,
                            staff.diaChi,
                            staff.email,
                            staff.maVaiTro,
                            tenVaiTro = staff.maVaiTro != null && roleDictionary.ContainsKey(staff.maVaiTro.ToString())
                                                            ? roleDictionary[staff.maVaiTro.ToString()]
                                                            : null
                        })
                        .ToList();
                return result;
            }
            catch
            {
                return new List<NhanVien>(); 
            }
        }
        public NhanVien GetStaffByUsername(string username)
        {
            return _context.NhanViens.FirstOrDefault(nv => nv.username.ToLower().Contains(username.ToLower()));
        }

    }
}
