using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Staff
{
    public interface IStaffRepository
    {
        List<NhanVien> GetStaffList();
        string GetLastStaffCode();
        dynamic GetStaffWithRoleNames();

        bool InsertStaff(NhanVien staff);

        bool DeleteStaff(string maNV);

        bool UpdateStaff(NhanVien updated);

        dynamic SearchStaff(string keyword);

        NhanVien GetStaffByUsername(string username);

    }
}
