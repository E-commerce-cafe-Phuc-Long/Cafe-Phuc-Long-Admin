using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor không tham số
        public Account_DTO() { }

        // Constructor có tham số
        public Account_DTO(string username, string password, string email, string phoneNumber)
        {
            Username = username;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        // Override ToString() để dễ dàng xem thông tin tài khoản
        public override string ToString()
        {
            return $"Username: {Username}, Email: {Email}, Phone: {PhoneNumber}";
        }
    }
}
