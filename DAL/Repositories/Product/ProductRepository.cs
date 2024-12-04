using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        public readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public ProductRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;
        }

        public List<SanPham> GetProductList()
        {
            return _context.SanPhams.ToList();
        }
        public List<SanPham> GetProductByCategoryId(string categoryId)
        {
            return _context.SanPhams
                .Where(prod => prod.maDM == categoryId)
                .ToList();
        }
        public SanPham GetProductByName(string productName)
        {
            return _context.SanPhams
                .FirstOrDefault(prod => prod.tenSP.ToLower().Contains(productName.ToLower()));

        }
        public SanPham GetProductByCode(string productId)
        {
            return _context.SanPhams
                .FirstOrDefault(prod => prod.maSP == productId);
        }
        public List<SanPham> GetProductListByName(string productName)
        {
            return _context.SanPhams
                .Where(prod => prod.tenSP.ToLower().Contains(productName.ToLower()))
                .ToList();

        }
        public bool InsertProduct(SanPham p)
        {
            try
            {
                _context.SanPhams.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteProduct(string masp)
        {
            try
            {
                var sp = _context.SanPhams.SingleOrDefault(p => p.maSP == masp);

                if (sp != null)
                {
                    sp.maTT = "TT002";
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
        public bool UpdateProduct(SanPham updated)
        {
            try
            {
                var nv = _context.SanPhams.SingleOrDefault(p => p.maSP == updated.maSP);

                if (nv != null)
                {
                    nv.tenSP = updated.tenSP;
                    nv.hinhAnh = updated.hinhAnh;
                    nv.donViTinh = updated.donViTinh;
                    nv.moTa = updated.moTa;
                    nv.spNoiBat = updated.spNoiBat;
                    nv.spMoi = updated.spMoi;
                    nv.maCT = updated.maCT;
                    nv.maDM = updated.maDM;

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
        public List<SanPham> SearchProduct(string keyword)
        {
            try
            {
                
                if (string.IsNullOrEmpty(keyword))
                {
                    return GetProductList();
                }

                var result = _context.SanPhams
                   .Where(nv => nv.maSP.Contains(keyword) ||
                             nv.tenSP.Contains(keyword))
                  
                                   .ToList();
               

                return result;
            }

            catch
            {
                return new List<SanPham>();
            }
        }
        public List<TrangThai_SP> trangThai_SPs()
        {
            return _context.TrangThai_SPs.ToList();
        }
        public string GetLastProductCode()
        {
            return _context.SanPhams
                .OrderByDescending(kh => kh.maSP)
                .Select(kh => kh.maSP)
                .FirstOrDefault();
        }
    }
}
