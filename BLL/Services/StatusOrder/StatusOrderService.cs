using BLL.Services.StatusOrder;
using DAL.Repositories.StatusOrder;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.StatusOrder
{
    public class StatusOrderService : IStatusOrderService
    {
        private readonly IStatusOrderRepository _repository;
        public StatusOrderService(IStatusOrderRepository repository)
        { 
            _repository = repository; 
        }
        public List<TrangThai_DH> GetStatusOrdersList()
        {
            return _repository.GetStatusOrdersList();
        }
        public TrangThai_DH updateStatusOrder(TrangThai_DH p)
        {
            return _repository.updateStatusOrder(p);
        }
    }
}
