using DAL.Repositories.OrderDetail;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.OrderDetail
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _repository;
        public OrderDetailService(IOrderDetailRepository repository)
        { 
            _repository = repository; 
        }
        public List<ChiTietDonHang> GetOrderDetailsList()
        {
            return _repository.GetOrderDetailsList();
        }
        public bool InsertOrderDetail(ChiTietDonHang p)
        {
            return _repository.InsertOrderDetail(p);
        }
        public List<ChiTietDonHang> GetOrderDetailsListByOrderCode(string orderCode)
        {
            return _repository.GetOrderDetailsListByOrderCode(orderCode);
        }
    }
}
