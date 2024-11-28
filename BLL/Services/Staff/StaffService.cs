using DAL.Repositories.Staff;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Staff
{
    public class StaffService:IStaffService
    {
        public readonly IStaffRepository _repository;
        public StaffService(IStaffRepository repository)
        {
            this._repository = repository;
        }

        public string GenerateStaffCode()
        {
            var lastCustomerCode = _repository.GetLastStaffCode();

            // Nếu chưa có nhân viên thì khởi tạo mã NV: NV001
            if (string.IsNullOrEmpty(lastCustomerCode))
            {
                return "NV001";
            }

            var number = int.Parse(lastCustomerCode.Substring(2));

            return $"NV{(number + 1):D3}";
        }

        public List<NhanVien> GetStaffList()
        {
            return _repository.GetStaffList();
        }

        public dynamic GetStaffWithRoleNames()
        {
            return _repository.GetStaffWithRoleNames();
        }

        public bool InsertStaff(NhanVien staff)
        {
            return _repository.InsertStaff(staff);
        }

        public bool DeleteStaff(string maNV)
        {
            return _repository.DeleteStaff(maNV);
        }

        public bool UpdateStaff(NhanVien staff)
        {
            return _repository.UpdateStaff(staff);
        }

        public dynamic SearchStaff(string keyword)
        {
            return _repository.SearchStaff(keyword);
        }


    }
}
