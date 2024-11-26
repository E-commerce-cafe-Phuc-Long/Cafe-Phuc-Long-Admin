using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IProductService
    {
        List<SanPham> GetProductList();
        string UploadImage(string imageUrl);
        List<SanPham> GetProductByCategoryId(string categoryId);
        SanPham GetProductByName(string productName);
        List<SanPham> GetProductListByName(string productName);
    }
}
