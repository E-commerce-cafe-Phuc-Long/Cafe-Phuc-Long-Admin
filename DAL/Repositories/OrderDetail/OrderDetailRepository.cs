using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.OrderDetail
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public OrderDetailRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<ChiTietDonHang> GetOrderDetailsList()
        {
            return _context.ChiTietDonHangs.ToList();
        }

        public List<ChiTietDonHang> GetOrderDetailsListByOrderCode(string orderCode)
        {
            return _context.ChiTietDonHangs.Where(p => p.maDH == orderCode).ToList();
        }
        public bool InsertOrderDetail(ChiTietDonHang p)
        {
            try
            {
                _context.ChiTietDonHangs.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
