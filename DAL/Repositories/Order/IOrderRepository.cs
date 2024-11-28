using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Order
{
    public interface IOrderRepository
    {
        List<DonHang> GetOrdersList();
        bool InsertOrder(DonHang p);
        string GetLastOrderCode();
    }
}
