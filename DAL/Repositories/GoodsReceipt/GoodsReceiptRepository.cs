using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Category.GoodsReceipt
{
    public class GoodsReceiptRepository : IGoodsReceiptRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public GoodsReceiptRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<PhieuNhap> GetGoodsReceiptList()
        {
            return _context.PhieuNhaps.ToList();
        }

        //tạo mã code
        public string GetCode()
        {
            return _context.PhieuNhaps
                .OrderByDescending(ma => ma.maPhieuNhap)
                .Select(ma => ma.maPhieuNhap)
                .FirstOrDefault();
        }


        //lấy danh sách bảng
        public dynamic GetData()
        {
            var NCCDictionary = _context.NhaCungCaps.ToDictionary(ncc => ncc.maNCC, ncc => ncc.tenNCC);

            return _context.PhieuNhaps.Select(p => new
            {
                p.maPhieuNhap,
                p.ngayNhapHang,
                p.tongTien,
                p.maNCC,
                tenNCC = p.maNCC != null && NCCDictionary.ContainsKey(p.maNCC.ToString())
                              ? NCCDictionary[(p.maNCC.ToString())]
                              : null
            }).ToList();
        }


        //Tạo phiếu nhập
        public void SaveGoodsReceipt(string maPhieuNhap, string maNCC, DateTime ngayNhap, List<ChiTietPhieuNhap> details)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieuNhap))
                {
                    maPhieuNhap = GetCode(); 
                }

                var existingReceipt = _context.PhieuNhaps.FirstOrDefault(p => p.maPhieuNhap == maPhieuNhap);

                if (existingReceipt != null)
                {
                    existingReceipt.maNCC = maNCC;
                    existingReceipt.ngayNhapHang = ngayNhap;

                    var oldDetails = _context.ChiTietPhieuNhaps.Where(d => d.maPhieuNhap == maPhieuNhap).ToList();
                    _context.ChiTietPhieuNhaps.DeleteAllOnSubmit(oldDetails);

                    foreach (var detail in details)
                    {
                        detail.maPhieuNhap = maPhieuNhap;
                    }

                    _context.ChiTietPhieuNhaps.InsertAllOnSubmit(details);
                }
                else
                {
                    var phieuNhap = new PhieuNhap
                    {
                        maPhieuNhap = maPhieuNhap,
                        maNCC = maNCC,
                        ngayNhapHang = ngayNhap,
                        tongTien = details.Sum(d => d.thanhTien)
                    };


                    _context.PhieuNhaps.InsertOnSubmit(phieuNhap);

                    foreach (var detail in details)
                    {
                        detail.maPhieuNhap = maPhieuNhap;
                    }

                    _context.ChiTietPhieuNhaps.InsertAllOnSubmit(details);
                }

                _context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu phiếu nhập: {ex.Message}");
            }
        }

    }

}



    


               










            

