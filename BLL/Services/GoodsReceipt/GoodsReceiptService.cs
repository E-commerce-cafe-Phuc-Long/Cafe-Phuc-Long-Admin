using DAL.Repositories.Category.GoodsReceipt;
using DAL.Repositories.Staff;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.GoodsReceipt
{
    public class GoodsReceiptService: IGoodsReceiptService
    {
        public readonly IGoodsReceiptRepository _repository;
        public GoodsReceiptService(IGoodsReceiptRepository repository)
        {
            this._repository = repository;
        }
        public List<PhieuNhap> GetGoodsReceiptList()
        {
            return _repository.GetGoodsReceiptList();
        }

        public bool InsertGoodsReceipt(PhieuNhap p, List<ChiTietPhieuNhap> chiTietPhieuNhaps)
        {
            return _repository.InsertGoodsReceipt(p, chiTietPhieuNhaps);
        }
    }
}
