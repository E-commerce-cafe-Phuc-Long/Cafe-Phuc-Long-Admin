using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Auth
{
    public class AuthRepository :IAuthRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public AuthRepository (E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public string getRoleByUsernamePassword(string username)
        {
            string role = _context.NhanViens.FirstOrDefault(empl => empl.username == username).VaiTro.tenVaiTro.ToString();
            return role;
        }
    }
}
