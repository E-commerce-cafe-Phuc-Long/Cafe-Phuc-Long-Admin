using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.GoodsReceiptDetails
{
    public interface IGoodsReceiptDetailsRepository
    {
        List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList();

        dynamic GetDetailsByGoodsReceiptId(string maPhieuNhap);
        bool Insert(string maPhieuNhap,ChiTietPhieuNhap p);

        NguyenLieu GetMaterialById(string materialId);
        void Update(NguyenLieu material);
    }
}
