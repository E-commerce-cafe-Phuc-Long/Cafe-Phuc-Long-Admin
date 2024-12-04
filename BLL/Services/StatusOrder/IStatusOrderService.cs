using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.StatusOrder
{
    public interface IStatusOrderService
    {
        List<TrangThai_DH> GetStatusOrdersList();
        TrangThai_DH updateStatusOrder(TrangThai_DH p);
    }
}
