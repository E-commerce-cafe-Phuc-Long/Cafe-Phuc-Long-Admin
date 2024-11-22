using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Customer
{
    public interface ICustomerRepository
    {
        List<KhachHang> GetCustomersList();

        bool InsertCustomer(KhachHang Customer);

        bool DeleteCustomer(string maKH);

        bool UpdateCustomer(KhachHang updated);

        List<KhachHang> SearchCustomer(string keyword);
    }
}
