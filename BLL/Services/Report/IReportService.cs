using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Report
{
    public interface IReportService
    {
        (decimal revenue, decimal expenditure) GetRevenueAndExpenditure(DateTime startDate, DateTime endDate);
    }
}
