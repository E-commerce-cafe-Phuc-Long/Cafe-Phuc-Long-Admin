using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.StatusOrder
{
    public class StatusOrderRepository : IStatusOrderRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public StatusOrderRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<TrangThai_DH> GetStatusOrdersList()
        {
            return _context.TrangThai_DHs.ToList();
        }
        public TrangThai_DH updateStatusOrder(TrangThai_DH p)
        {
            var statusOrder = _context.TrangThai_DHs.FirstOrDefault(x => x.maTT == p.maTT);
            if (statusOrder != null)
            {
                statusOrder.tenTT = p.tenTT;
                _context.SubmitChanges();
            }
            return statusOrder;
        }

    }
}
