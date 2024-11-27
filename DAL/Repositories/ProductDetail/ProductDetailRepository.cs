using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ProductDetail
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public ProductDetailRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<ChiTietSanPham> GetProductDetailList()
        {
            return _context.ChiTietSanPhams.ToList();
        }
        public List<ChiTietSanPham> GetProductDetailsByProductId(string productId)
        {
            return _context.ChiTietSanPhams
                .Where(prod => prod.maSP == productId)
                .ToList();
        }
        public ChiTietSanPham GetProductDetailByIdAndSizeId(string productId, string sizeId)
        {
            return _context.ChiTietSanPhams
                .FirstOrDefault(prod => prod.maSP == productId && prod.Size.maSize == sizeId);
        }
        public bool InsertProductDetail(ChiTietSanPham p)
        {
            try
            {
                _context.ChiTietSanPhams.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteProductDetail(string maCTSP)
        {
            try
            {
                var productDetail = _context.ChiTietSanPhams.SingleOrDefault(p => p.maCTSP == maCTSP);

                if (productDetail != null)
                {
                    _context.ChiTietSanPhams.DeleteOnSubmit(productDetail);
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
        public bool UpdateProductDetail(ChiTietSanPham updated)
        {
            try
            {
                var productDetail = _context.ChiTietSanPhams.SingleOrDefault(p => p.maSP == updated.maSP && p.maSize == updated.maSize);

                if (productDetail != null)
                {
                    productDetail.maSize = updated.maSize;
                    productDetail.donGia = updated.donGia;
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

        
        public string GetLastProductDetailCode()
        {
            return _context.ChiTietSanPhams
                .OrderByDescending(kh => kh.maCTSP)
                .Select(kh => kh.maCTSP)
                .FirstOrDefault();
        }

    }
}
