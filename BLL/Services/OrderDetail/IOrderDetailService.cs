using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.OrderDetail
{
    public interface IOrderDetailService
    {
        List<ChiTietDonHang> GetOrderDetailsList();
        bool InsertOrderDetail(ChiTietDonHang p);
        List<ChiTietDonHang> GetOrderDetailsListByOrderCode(string orderCode);
    }
}
