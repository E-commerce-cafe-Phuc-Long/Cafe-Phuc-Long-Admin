using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Category.GoodsReceipt
{
    public class GoodsReceiptRepository:IGoodsReceiptRepository
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

        //Insert
        public bool InsertGoodsReceipt(PhieuNhap p, List<ChiTietPhieuNhap> chiTietPhieuNhaps)
        {
            try
            {
                _context.PhieuNhaps.InsertOnSubmit(p);

                foreach (var chiTiet in chiTietPhieuNhaps)
                {
                    var entityChiTiet = new ChiTietPhieuNhap
                    {
                        maPhieuNhap = p.maPhieuNhap, 
                        maNL = chiTiet.maNL,
                        soLuongNhap = chiTiet.soLuongNhap,
                        donGia = chiTiet.donGia,
                        thanhTien = chiTiet.thanhTien
                    };

                    _context.ChiTietPhieuNhaps.InsertOnSubmit(entityChiTiet);
                }

                _context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }





    }
}
