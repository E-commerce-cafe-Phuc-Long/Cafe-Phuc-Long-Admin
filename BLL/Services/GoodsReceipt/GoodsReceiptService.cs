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

        public string GenerateCode()
        {
            var lastCode = _repository.GetCode();

            // Nếu chưa có thì khởi tạo mã NV: NV001
            if (string.IsNullOrEmpty(lastCode))
            {
                return "PN001";
            }

            var number = int.Parse(lastCode.Substring(2));

            return $"PN{(number + 1):D3}";
        }

        //tạo
        public void SaveGoodsReceipt(string maPhieuNhap, string maNCC, DateTime ngayNhap, List<ChiTietPhieuNhap> details)
        {
            _repository.SaveGoodsReceipt(maPhieuNhap,maNCC,ngayNhap,details);
        }


    }
}
