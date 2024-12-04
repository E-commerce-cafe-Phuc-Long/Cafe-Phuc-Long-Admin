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
        List<DonHang> GetOrdersListByTT(string maTT);
        bool InsertOrder(DonHang p);
        bool UpdateStatusOrder(string maDH, string maTT);
        string GetLastOrderCode();
    }
}
