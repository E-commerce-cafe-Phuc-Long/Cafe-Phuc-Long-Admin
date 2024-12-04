using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public OrderRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<DonHang> GetOrdersList()
        {
            return _context.DonHangs.OrderByDescending(kh => kh.ngayLapDH).ToList();
        }
        public List<DonHang> GetOrdersListByTT(string maTT)
        {
            return _context.DonHangs
                .Where(kh => kh.maTT == maTT)
                .OrderByDescending(kh => kh.ngayLapDH)
                .ToList();
        }
        public string GetLastOrderCode()
        {
            return _context.DonHangs
                .OrderByDescending(kh => kh.maDH)
                .Select(kh => kh.maDH)
                .FirstOrDefault();
        }
        public bool InsertOrder(DonHang p)
        {
            try
            {
                _context.DonHangs.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool UpdateStatusOrder(string maDH,string maTT)
        {
            try
            {
                var order = _context.DonHangs.SingleOrDefault(p => p.maDH == maDH);

                if (order != null)
                {
                    order.maTT = maTT;

                    _context.SubmitChanges();

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
