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
    }
}
