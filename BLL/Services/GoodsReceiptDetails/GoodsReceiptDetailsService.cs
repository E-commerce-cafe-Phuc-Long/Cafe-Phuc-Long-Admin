using BLL.Services.GoodsReceipt;
using DAL.Repositories.Category.GoodsReceipt;
using DAL.Repositories.GoodsReceiptDetails;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Services.GoodsReceiptDetails.GoodsReceiptDetailsService;

namespace BLL.Services.GoodsReceiptDetails
{
    public class GoodsReceiptDetailsService : IGoodsReceiptDetailsService
    {
            public readonly IGoodsReceiptDetailsRepository _repository;
            public GoodsReceiptDetailsService(IGoodsReceiptDetailsRepository repository)
            {
                this._repository = repository;
            }
            public List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList()
            {
                return _repository.GetGoodsReceiptDetailsList();
            }

            public dynamic GetDetailsByGoodsReceiptId(string maPhieuNhap)
            { return _repository.GetDetailsByGoodsReceiptId(maPhieuNhap); } 
        
             public bool Insert(string maPhieuNhap,ChiTietPhieuNhap p)
             { return _repository.Insert(maPhieuNhap,p); }


        public void UpdateMaterialQuantity(string maNL, decimal? soLuongNhap)
        {
            // Lấy thông tin nguyên liệu theo mã nguyên liệu (maNL)
            var material = _repository.GetMaterialById(maNL);

            // Kiểm tra nếu material không tồn tại
            if (material == null)
            {
                throw new Exception("Nguyên liệu không tồn tại!");
            }

            // Nếu soLuong là null, gán giá trị mặc định là 0
            material.soLuong = (material.soLuong ?? 0) + (soLuongNhap ?? 0);  // Cộng thêm soLuongNhap vào soLuong

            // Cập nhật thông tin nguyên liệu vào kho dữ liệu
            _repository.Update(material);
        }
        public void Update(NguyenLieu material)
        { _repository.Update(material); }


    }
}
