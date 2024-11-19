﻿using DTO;
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
        List<SanPham> GetProductByCategoryId(string categoryId);
    }
}
