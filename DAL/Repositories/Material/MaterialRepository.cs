using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Material
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public MaterialRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<NguyenLieu> GetMaterialsList()
        {
            return _context.NguyenLieus.ToList();
        }
          public string GetCode()
        {
            return _context.PhieuNhaps
                .OrderByDescending(ma => ma.maPhieuNhap)
                .Select(ma => ma.maPhieuNhap)
                .FirstOrDefault();
        }
        public string GetMaterialNameById(string maNL)
        {
            try
            {
                var material = _context.NguyenLieus.FirstOrDefault(nl => nl.maNL == maNL);

                return material?.tenNL ?? "Không tìm thấy nguyên liệu";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tên nguyên liệu: " + ex.Message);
            }
        }
 
        public string GetLastMaterialCode()
        {
            return _context.NguyenLieus
                .OrderByDescending(kh => kh.maNL)
                .Select(kh => kh.maNL)
                .FirstOrDefault();
        }
        public bool InsertMaterial(NguyenLieu nguyenLieu)
        {
            try
            {
                _context.NguyenLieus.InsertOnSubmit(nguyenLieu);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMaterial(string maNL)
        {
            try
            {
                var nguyenlieu = _context.NguyenLieus.SingleOrDefault(p => p.maNL == maNL);

                if (nguyenlieu != null)
                {
                    _context.NguyenLieus.DeleteOnSubmit(nguyenlieu);
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
        public bool UpdateMaterial(NguyenLieu updated)
        {
            try
            {
                var nv = _context.NguyenLieus.SingleOrDefault(p => p.maNL == updated.maNL);

                if (nv != null)
                {
                    nv.tenNL = updated.tenNL;
                    nv.donViTinh = updated.donViTinh;
                    nv.soLuong = updated.soLuong;
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
        public List<NguyenLieu> SearchMaterial(string keyword)
        {
            try
            {

                if (string.IsNullOrEmpty(keyword))
                {
                    return GetMaterialsList();
                }

                var result = _context.NguyenLieus.Where(nv => nv.maNL.Contains(keyword) ||
                             nv.tenNL.Contains(keyword))
                                   .ToList();
                return result;
            }

            catch
            {
                return new List<NguyenLieu>();
            }
        }

    }
}
