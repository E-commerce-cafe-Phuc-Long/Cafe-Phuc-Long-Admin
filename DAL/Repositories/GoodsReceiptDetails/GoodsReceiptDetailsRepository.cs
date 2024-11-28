using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.GoodsReceiptDetails
{
    public class GoodsReceiptDetailsRepository : IGoodsReceiptDetailsRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public GoodsReceiptDetailsRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList()
        {
            return _context.ChiTietPhieuNhaps.ToList();
        }


        //Lấy danh sách chi tiết phiếu nhập
        public dynamic GetDetailsByGoodsReceiptId(string maPhieuNhap)
        {
            var NLDictionary = _context.NguyenLieus.ToDictionary(ncc => ncc.maNL, ncc => ncc.tenNL);

            var details = _context.ChiTietPhieuNhaps
                .Where(c => c.maPhieuNhap == maPhieuNhap)
                .Select(p => new
                {
                    TenNL = NLDictionary.ContainsKey(p.maNL) ? NLDictionary[p.maNL] : null, // Đặt tên nguyên liệu trước
                    p.maNL,
                    p.soLuongNhap,
                    p.donGia,
                    p.thanhTien
                })
                .ToList();

            return details;
        }


        //



        //thêm
        public bool Insert(string maPhieuNhap, ChiTietPhieuNhap p)
        {
            try
            {
                p.maPhieuNhap = maPhieuNhap;

                var phieuNhap = _context.PhieuNhaps.FirstOrDefault(pn => pn.maPhieuNhap == p.maPhieuNhap);

                if (phieuNhap == null)
                {

                    return false;
                }

                _context.ChiTietPhieuNhaps.InsertOnSubmit(p);


                return true;
            }
            catch
            {
                return false;
            }
        }



        //xóa 












    }
}

