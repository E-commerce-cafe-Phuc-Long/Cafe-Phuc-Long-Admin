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
        public dynamic GetData() { return _repository.GetData(); }

        public bool Insert(PhieuNhap p)
        {
            return _repository.Insert(p);
        }
        public bool Delete(string maPhieuNhap)
        { return _repository.Delete(maPhieuNhap); }
        public bool Update(PhieuNhap updated)
        {  return _repository.Update(updated); }


    }
}
