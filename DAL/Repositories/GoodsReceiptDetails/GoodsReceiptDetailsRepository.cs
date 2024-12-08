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

        public NguyenLieu GetMaterialById(string materialId)
        {
            try
            {
                // Truy vấn nguyên liệu theo maNL
                var material = _context.NguyenLieus.SingleOrDefault(m => m.maNL == materialId);
                return material; // Nếu tìm thấy, trả về nguyên liệu; nếu không, trả về null
            }
            catch (Exception ex)
            {
                // Ghi log hoặc xử lý lỗi nếu có
                Console.WriteLine($"Lỗi khi tìm nguyên liệu: {ex.Message}");
                throw; // Ném lại lỗi để phía Service có thể xử lý
            }
        }

        public void Update(NguyenLieu material)
        {
            try
            {
                // Tìm nguyên liệu theo MaNL
                var existingMaterial = _context.NguyenLieus.SingleOrDefault(m => m.maNL == material.maNL);

                if (existingMaterial != null)
                {
                    // Cập nhật thuộc tính SoLuong
                    existingMaterial.soLuong = material.soLuong;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    _context.SubmitChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy nguyên liệu cần cập nhật.");
                }
            }
            catch (Exception ex)
            {
                // Ghi log hoặc xử lý lỗi
                Console.WriteLine($"Lỗi khi cập nhật nguyên liệu: {ex.Message}");
                throw;
            }
        }
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

