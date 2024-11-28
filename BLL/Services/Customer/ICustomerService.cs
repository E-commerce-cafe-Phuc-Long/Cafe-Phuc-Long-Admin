using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Customer
{
    public interface ICustomerService
    {

        List<KhachHang> GetCustomersList();

        bool InsertCustomer(KhachHang nv);
        bool DeleteCustomer(string maKH);
        bool UpdateCustomer(KhachHang update);
        dynamic SearchCustomer(string keyword);
        KhachHang GetCustomerByPhone(string phone);

    }
}
