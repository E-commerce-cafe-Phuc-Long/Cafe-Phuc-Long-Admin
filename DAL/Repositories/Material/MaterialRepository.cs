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

    }
}
