using DAL.Repositories.Customer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Customer
{

    public class CustomerService: ICustomerService
    {
        public readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }
        public List<KhachHang> GetCustomerList()
        {
            return _repository.GetCustomersList();
        }

        public bool InsertCustomer(KhachHang Customer)
        {
            return _repository.InsertCustomer(Customer);
        }

        public bool DeleteCustomer(string maKH)
        {
            return _repository.DeleteCustomer(maKH);
        }

        public bool UpdateCustomer(KhachHang update)
        {
            return _repository.UpdateCustomer(update);
        }

        public List<KhachHang> SearchCustomer(string keyword)
        { return _repository.SearchCustomer(keyword);}

        public List<KhachHang> GetCustomersList()
        {
            throw new NotImplementedException();
        }
    }
}
