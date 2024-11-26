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
                    p.maNL,
                    TenNL = NLDictionary.ContainsKey(p.maNL) ? NLDictionary[p.maNL] : null, 
                    p.soLuongNhap,
                    p.donGia,
                    p.thanhTien
                })
                .ToList();

            return details;
        }



        //public dynamic GetDetailsByGoodsReceiptId(string maPhieuNhap)
        //{
        //    try
        //    {
        //        var NCCDictionary = _context.NhaCungCaps.ToDictionary(ncc => ncc.maNCC, ncc => ncc.tenNCC);

        //        // Tạo từ điển nguyên liệu
        //        var NLDictionary = _context.NguyenLieus.ToDictionary(nl => nl.maNL, nl => nl.tenNL);

        //        var phieuNhapWithDetails = _context.PhieuNhaps
        //            .Where(p => p.maPhieuNhap == maPhieuNhap)  // Thêm điều kiện lọc để chỉ lấy phiếu nhập theo mã
        //            .Select(p => new
        //            {
        //                p.maPhieuNhap,
        //                p.ngayNhapHang,
        //                p.tongTien,
        //                p.maNCC,
        //                // Lấy tên nhà cung cấp từ từ điển đã tạo
        //                TenNCC = NCCDictionary.ContainsKey(p.maNCC) ? NCCDictionary[p.maNCC] : null,
        //                ChiTietPhieuNhaps = _context.ChiTietPhieuNhaps
        //                    .Where(ct => ct.maPhieuNhap == p.maPhieuNhap)
        //                    .Select(ct => new
        //                    {
        //                        ct.maNL,
        //                        // Lấy tên nguyên liệu từ từ điển đã tạo
        //                        tenNL = NLDictionary.ContainsKey(ct.maNL) ? NLDictionary[ct.maNL] : null,
        //                        ct.soLuongNhap,
        //                        ct.donGia,
        //                        ct.thanhTien
        //                    })
        //                    .ToList()
        //            })
        //            .ToList();

        //        // Chuyển đổi danh sách con thành các dòng phẳng để dễ hiển thị
        //        var flatList = new List<object>();
        //        foreach (var phieu in phieuNhapWithDetails)
        //        {
        //            foreach (var chiTiet in phieu.ChiTietPhieuNhaps)
        //            {
        //                flatList.Add(new
        //                {
        //                    phieu.maPhieuNhap,
        //                    phieu.ngayNhapHang,
        //                    phieu.maNCC,
        //                    phieu.TenNCC,
        //                    phieu.tongTien,
        //                    chiTiet.maNL,
        //                    chiTiet.tenNL,
        //                    chiTiet.soLuongNhap,
        //                    chiTiet.donGia,
        //                    chiTiet.thanhTien
        //                });
        //            }
        //        }

        //        return flatList;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log lỗi chi tiết
        //        Console.Error.WriteLine($"Error in GetData: {ex.Message}");
        //        return new { success = false, message = "Có lỗi xảy ra khi lấy dữ liệu." };
        //    }
        //}









    }
}

