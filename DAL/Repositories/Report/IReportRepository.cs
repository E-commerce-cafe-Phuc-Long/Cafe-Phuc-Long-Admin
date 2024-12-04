using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Report
{
    public interface IReportRepository
    {
        (decimal revenue, decimal expenditure) GetRevenueAndExpenditure(DateTime startDate, DateTime endDate);


     }
}
