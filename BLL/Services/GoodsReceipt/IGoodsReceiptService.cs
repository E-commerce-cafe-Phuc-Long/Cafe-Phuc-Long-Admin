using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.GoodsReceipt
{
    public interface IGoodsReceiptService
    {
        List<PhieuNhap> GetGoodsReceiptList();
        bool InsertGoodsReceipt(PhieuNhap p, List<ChiTietPhieuNhap> chiTietPhieuNhaps);
    }
}
