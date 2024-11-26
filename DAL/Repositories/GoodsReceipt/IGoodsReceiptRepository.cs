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
        bool Insert(PhieuNhap p);
        bool Delete(string maPhieuNhap);
        bool Update(PhieuNhap updated);

    }
}
