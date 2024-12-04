using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Account
{
    public class AccountRepository:IAccountRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public AccountRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }

        //lấy danh sách tài khoản
        public IEnumerable<Account_DTO> GetAccountsInfo()
        {
            // Lấy thông tin từ bảng NhanVien
            var nhanVienAccounts = _context.NhanViens.Select(nv => new Account_DTO
            {
                Username = nv.username,
                Password = nv.matKhau,
                Email = nv.email,
                PhoneNumber = nv.soDT,
            }); ;

            // Lấy thông tin từ bảng KhachHang
            var khachHangAccounts = _context.KhachHangs.Select(kh => new Account_DTO
            {
                Username = kh.username,
                Password = kh.matKhau,
                Email = kh.email,
                PhoneNumber = kh.soDT,
            });

            // Gộp thông tin từ hai bảng
            var allAccounts = nhanVienAccounts.Union(khachHangAccounts).ToList();

            return allAccounts;
        }

        // Tìm kiếm tài khoản theo từ khóa (số điện thoại hoặc email)
        public IEnumerable<Account_DTO> SearchAccountsByPhoneOrEmail(string keyword)
        {
            var accounts = _context.NhanViens
                .Where(nv => nv.soDT == keyword || nv.email == keyword)
                .Select(nv => new Account_DTO
                {
                    Username = nv.username,
                    Password = nv.matKhau,
                    Email = nv.email,
                    PhoneNumber = nv.soDT,
                })
                .Union(_context.KhachHangs
                    .Where(kh => kh.soDT == keyword || kh.email == keyword)
                    .Select(kh => new Account_DTO
                    {
                        Username = kh.username,
                        Password = kh.matKhau,
                        Email = kh.email,
                        PhoneNumber = kh.soDT,
                    }))
                .ToList();

            return accounts;
        }



    }
}
