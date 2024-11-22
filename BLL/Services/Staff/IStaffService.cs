using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Staff
{
    public interface IStaffService
    {
     
        List<NhanVien> GetStaffList();
        bool InsertStaff(NhanVien newStaff);

        bool DeleteStaff(string maNV);
        bool UpdateStaff(NhanVien nv);

        List<NhanVien> SearchStaff(string keyword);
    }
}
