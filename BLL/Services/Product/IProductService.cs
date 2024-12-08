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
        SanPham GetProductByCode(string productId);
        List<SanPham> GetProductListByName(string productName);
        bool InsertProduct(SanPham nv);
        bool DeleteProduct(string masp);
        bool UpdateProduct(SanPham update);
        List<SanPham> SearchProduct(string keyword);
        List<TrangThai_SP> trangThai_SPs();
        string GenerateProductCode();

        List<SanPham> SearchProduct_Manager(string keyword);
        List<SanPham> GetProductList_Manager();
        List<SanPham> GetProductByCategoryId_Manager(string categoryId);
    }
}
