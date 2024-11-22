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

        bool InsertStaff(NhanVien staff);

        bool DeleteStaff(string maNV);

        bool UpdateStaff(NhanVien updated);

        List<NhanVien> SearchStaff(string keyword);

    }
}
