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
        dynamic GetData();
        string GetCode();
        void SaveGoodsReceipt(string maPhieuNhap, string maNCC, DateTime ngayNhap, List<ChiTietPhieuNhap> details);
    }
}
