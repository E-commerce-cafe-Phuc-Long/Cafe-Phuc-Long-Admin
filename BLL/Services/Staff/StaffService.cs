using DAL.Repositories.Staff;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();

            // Chuyển đổi mật khẩu thành mảng byte (dạng mã hóa UTF-8)
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Băm mật khẩu (sử dụng SHA-256)
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            // sử dụng StringBuilder giúp lưu trữ chuỗi trong quá trình lặp
            StringBuilder hex = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                hex.Append(b.ToString("x2")); //x: Hiển thị số ở dạng hexadecimal chữ thường - 2 : là số ký tự 
            }
            return hex.ToString();
        }
        public bool VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            string hashOfProvidedPassword = HashPassword(providedPassword);
            if (hashOfProvidedPassword == hashedPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
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
