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
            return _context.DonHangs.ToList();
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
    }
}
