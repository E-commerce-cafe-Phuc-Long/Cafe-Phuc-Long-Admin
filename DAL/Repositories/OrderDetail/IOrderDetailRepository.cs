using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.OrderDetail
{
    public interface IOrderDetailRepository
    {
        List<ChiTietDonHang> GetOrderDetailsList();
        bool InsertOrderDetail(ChiTietDonHang p);
        List<ChiTietDonHang> GetOrderDetailsListByOrderCode(string orderCode);
    }
}
