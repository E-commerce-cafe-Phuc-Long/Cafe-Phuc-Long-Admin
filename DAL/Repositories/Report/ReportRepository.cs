using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;



namespace DAL.Repositories.Report
{
    public class ReportRepository : IReportRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;

        public ReportRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }

        // Hàm thống kê doanh thu 
        public (decimal revenue, decimal expenditure) GetRevenueAndExpenditure(DateTime startDate, DateTime endDate)
        {
            // Tính tổng doanh thu từ các đơn hàng trong khoảng thời gian
            var revenue = _context.DonHangs
                .Where(dh => dh.ngayLapDH >= startDate && dh.ngayLapDH <= endDate)
                .Join(
                    _context.ChiTietDonHangs,
                    dh => dh.maDH,
                    ctdh => ctdh.maDH,
                    (dh, ctdh) => ctdh.thanhTien
                )
                .Sum() ?? 0; // Xử lý null

            // Tính tổng chi tiêu từ các phiếu nhập trong khoảng thời gian
            var expenditure = _context.PhieuNhaps
                .Where(pn => pn.ngayNhapHang >= startDate && pn.ngayNhapHang <= endDate)
                .Sum(pn => pn.tongTien) ?? 0; // Xử lý null

            return (revenue, expenditure);
        }
    }
}
