using DAL.Repositories.Product;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            this._repository = repository;
        }
        public List<SanPham> GetProductList()
        {
            return _repository.GetProductList();
        }
        public List<SanPham> GetProductByCategoryId(string categoryId)
        {
            return _repository.GetProductByCategoryId(categoryId);
        }
        public SanPham GetProductByName(string productName)
        {
            return _repository.GetProductByName(productName);
        }
        public List<SanPham> GetProductListByName(string productName)
        {
            return _repository.GetProductListByName(productName);
        }
    }
}
