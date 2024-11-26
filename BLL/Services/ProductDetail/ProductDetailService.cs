using DAL.Repositories.ProductDetail;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ProductDetail
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IProductDetailRepository _repository;
        public ProductDetailService(IProductDetailRepository repository)
        { 
            _repository = repository; 
        }
        public List<ChiTietSanPham> GetProductDetailList()
        {
            return _repository.GetProductDetailList();
        }
        public List<ChiTietSanPham> GetProductDetailsByProductId(string productId)
        {
            return _repository.GetProductDetailsByProductId(productId);
        }
        public ChiTietSanPham GetProductDetailByIdAndSizeId(string productId, string sizeId)
        {
            return _repository.GetProductDetailByIdAndSizeId(productId, sizeId);
        }
    }
}
