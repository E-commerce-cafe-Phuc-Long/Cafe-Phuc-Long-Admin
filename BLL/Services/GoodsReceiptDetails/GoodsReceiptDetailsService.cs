using BLL.Services.GoodsReceipt;
using DAL.Repositories.Category.GoodsReceipt;
using DAL.Repositories.GoodsReceiptDetails;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Services.GoodsReceiptDetails.GoodsReceiptDetailsService;

namespace BLL.Services.GoodsReceiptDetails
{
    public class GoodsReceiptDetailsService:IGoodsReceiptDetailsService
    {
            public readonly IGoodsReceiptDetailsRepository _repository;
            public GoodsReceiptDetailsService(IGoodsReceiptDetailsRepository repository)
            {
                this._repository = repository;
            }
            public List<ChiTietPhieuNhap> GetGoodsReceiptDetailsList()
            {
                return _repository.GetGoodsReceiptDetailsList();
            }

        
    }
}
