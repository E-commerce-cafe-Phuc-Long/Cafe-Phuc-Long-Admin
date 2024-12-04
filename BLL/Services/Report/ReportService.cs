using DAL.Repositories.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Report
{
    public class ReportService : IReportService
    {
        public readonly IReportRepository _repository;

        public ReportService(IReportRepository repository)
        {
            this._repository = repository;
        }


        public (decimal revenue, decimal expenditure) GetRevenueAndExpenditure(DateTime startDate, DateTime endDate)
        {

            return _repository.GetRevenueAndExpenditure(startDate, endDate);
        }
    }
}
