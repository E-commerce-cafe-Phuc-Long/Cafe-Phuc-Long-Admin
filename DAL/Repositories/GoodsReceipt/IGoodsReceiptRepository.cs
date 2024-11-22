using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Category.GoodsReceipt
{
    public interface IGoodsReceiptRepository
    {
        List<PhieuNhap> GetGoodsReceiptList();
        bool InsertGoodsReceipt(PhieuNhap p, List<ChiTietPhieuNhap> chiTietPhieuNhaps);
    }
}
