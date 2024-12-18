﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ProductDetail
{
    public interface IProductDetailService
    {
        List<ChiTietSanPham> GetProductDetailList();
        List<ChiTietSanPham> GetProductDetailsByProductId(string productId);
        ChiTietSanPham GetProductDetailByIdAndSizeId(string productId, string sizeId);
        ChiTietSanPham GetProductDetailByCode(string productDetailId);
        bool InsertProductDetail(ChiTietSanPham p);
        bool DeleteProductDetail(string maCTSP);
        bool UpdateProductDetail(ChiTietSanPham update);
        string GenerateProductDetailCode();

    }
}
