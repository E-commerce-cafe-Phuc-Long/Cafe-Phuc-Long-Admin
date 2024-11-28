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
        public bool InsertProductDetail(ChiTietSanPham p)
        {
            return _repository.InsertProductDetail(p);
        }
        public bool DeleteProductDetail(string maCTSP)
        {
            return _repository.DeleteProductDetail(maCTSP);
        }
        public bool UpdateProductDetail(ChiTietSanPham update)
        {
            return _repository.UpdateProductDetail(update);
        }
        public string GenerateProductDetailCode()
        {
            var lastProductDetailCode = _repository.GetLastProductDetailCode();

            if (string.IsNullOrEmpty(lastProductDetailCode))
            {
                return "CTSP001";
            }

            var number = int.Parse(lastProductDetailCode.Substring(4));

            return $"CTSP{(number + 1):D3}";
        }
    }
}
