using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.GoodsReceiptDetails
{
    public class GoodsReceiptDetailsRepository:IGoodsReceiptDetailsRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public GoodsReceiptDetailsRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList()
        {
            return _context.ChiTietPhieuNhaps.ToList();
        }
    }
}
