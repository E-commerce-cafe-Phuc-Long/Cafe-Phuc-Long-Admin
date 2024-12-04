using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.StatusOrder
{
    public interface IStatusOrderRepository
    {
        List<TrangThai_DH> GetStatusOrdersList();
        TrangThai_DH updateStatusOrder(TrangThai_DH p);
    }
}
