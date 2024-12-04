using DAL.Repositories.Order;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        public OrderService(IOrderRepository repository)
        { 
            _repository = repository; 
        }
        public List<DonHang> GetOrdersList()
        {
            return _repository.GetOrdersList();
        }
        public List<DonHang> GetOrdersListByTT(string maTT)
        {
            return _repository.GetOrdersListByTT(maTT);
        }
        public bool UpdateStatusOrder(string maDH, string maTT)
        {
            return _repository.UpdateStatusOrder(maDH, maTT);
        }
        public bool InsertOrder(DonHang p)
        {
            return _repository.InsertOrder(p);
        }
        public string GenerateOrderCode()
        {
            var lastOrderCode = _repository.GetLastOrderCode();

            if (string.IsNullOrEmpty(lastOrderCode))
            {
                return "DH001";
            }

            var number = int.Parse(lastOrderCode.Substring(2));

            return $"DH{(number + 1):D3}";
        }
    }
}
