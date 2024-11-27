using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Product
{
    public interface IProductRepository
    {
        List<SanPham> GetProductList();
        List<SanPham> GetProductByCategoryId(string categoryId);
        SanPham GetProductByName(string productName);
        List<SanPham> GetProductListByName(string productName);
    }
}
