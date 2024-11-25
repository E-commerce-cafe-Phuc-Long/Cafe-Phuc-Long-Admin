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

        //Thêm
        public bool Insert(PhieuNhap p)
        {
            try
            {
                _context.PhieuNhaps.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        //Xóa
        public bool Delete(string maPhieuNhap)
        {
            try
            {
                var kh = _context.PhieuNhaps.SingleOrDefault(p => p.maPhieuNhap == maPhieuNhap);

                if (kh != null)
                {
                    _context.PhieuNhaps.DeleteOnSubmit(kh);
                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        //Sửa
        public bool Update(PhieuNhap updated)
        {
            try
            {
                var nv = _context.PhieuNhaps.SingleOrDefault(p => p.maNCC == updated.maNCC);

                if (nv != null)
                {
                    nv.ngayNhapHang = updated.ngayNhapHang;
                    nv.maNCC = updated.maNCC;
                    nv.tongTien = updated.tongTien;

                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        //tìm kiếm
        //public dynamic Search(string keyword)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(keyword))
        //        {
        //            return GetData();
        //        }

        //        var NCCDictionary = _context.NhaCungCaps.ToDictionary(ncc => ncc.maNCC, ncc => ncc.tenNCC);

        //        var result = _context.PhieuNhaps
        //            .Where(nv => nv.maPhieuNhap.Contains(keyword) ||
        //                         nv.tenNV.Contains(keyword))
        //               .Select(staff => new
        //               {
        //                   staff.maNV,
        //                   staff.username,
        //                   staff.matKhau,
        //                   staff.tenNV,
        //                   staff.ngaySinh,
        //                   staff.soDT,
        //                   staff.diaChi,
        //                   staff.email,
        //                   staff.maVaiTro,
        //                   tenVaiTro = staff.maVaiTro != null && roleDictionary.ContainsKey(staff.maVaiTro.ToString())
        //                                                 ? roleDictionary[staff.maVaiTro.ToString()]
        //                                                 : null
        //               })
        //                               .ToList();

        //        return result;
        //    }

        //    catch
        //    {
        //        return new List<NhanVien>();
        //    }
        //}






    }
}

               










            

