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
        public List<NhanVien> GetStaffList()
        {
            return _repository.GetStaffList();
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

        public List<NhanVien> SearchStaff(string keyword)
        {
            return _repository.SearchStaff(keyword);
        }

    }
}
