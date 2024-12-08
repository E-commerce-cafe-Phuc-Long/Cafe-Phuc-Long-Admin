using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.GoodsReceiptDetails
{
    public interface IGoodsReceiptDetailsService
    {
        List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList();

        dynamic GetDetailsByGoodsReceiptId(string maPhieuNhap);
        bool Insert(string maPhieuNhap, ChiTietPhieuNhap p);
        void UpdateMaterialQuantity(string maNL, decimal? soLuongNhap);
        void Update(NguyenLieu material);
    }
}
