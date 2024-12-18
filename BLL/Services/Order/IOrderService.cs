﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Order
{
    public interface IOrderService
    {
        List<DonHang> GetOrdersList();
        bool InsertOrder(DonHang p);
        bool UpdateStatusOrder(string maDH, string maTT);
        List<DonHang> GetOrdersListByTT(string maTT);
        string GenerateOrderCode();
    }
}
