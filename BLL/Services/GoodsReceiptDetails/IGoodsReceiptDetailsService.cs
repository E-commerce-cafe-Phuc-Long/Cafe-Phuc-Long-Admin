using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.GoodsReceiptDetails
{
    public interface IGoodsReceiptDetailsService
    {
        List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList();
    }
}
