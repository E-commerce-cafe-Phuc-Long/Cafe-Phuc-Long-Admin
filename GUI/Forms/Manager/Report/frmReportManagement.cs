using BLL.Services.Report;
using System;
using System.Windows.Forms;

namespace GUI.Forms.Manager.Report
{
    public partial class frmReportManagement : Form
    {
        private readonly IReportService _reportService;

        // Constructor
        public frmReportManagement(IReportService reportService)
        {
            InitializeComponent();
            this._reportService = reportService;
        }

        private void frmReportManagement_Load(object sender, EventArgs e)
        {
            // Đặt ngày bắt đầu và ngày kết thúc
            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = DateTime.Now;

            // Lấy dữ liệu từ dịch vụ báo cáo
            var result = _reportService.GetRevenueAndExpenditure(startDate, endDate);

            decimal revenue = result.revenue;
            decimal expenditure = result.expenditure;

            // Cập nhật thông tin vào TextBox
            txt_tongDoanhThu.Text = $"Revenue: {revenue:C}";
            txt_donHang.Text = $"Expenditure: {expenditure:C}";

            // Xóa các Series cũ
            chart1.Series.Clear();

            // Tạo Series cho Revenue
            var revenueSeries = chart1.Series.Add("Revenue");
            revenueSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            revenueSeries.Points.AddXY("Total Revenue", revenue);

            // Tạo Series cho Expenditure
            var expenditureSeries = chart1.Series.Add("Expenditure");
            expenditureSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            expenditureSeries.Points.AddXY("Total Expenditure", expenditure);

            // Cấu hình trục X và Y
            chart1.ChartAreas[0].AxisX.Title = "Categories";
            chart1.ChartAreas[0].AxisY.Title = "Amount (in Currency)";
            chart1.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo hiển thị tất cả nhãn trên trục X
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của chart (nếu cần)
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
