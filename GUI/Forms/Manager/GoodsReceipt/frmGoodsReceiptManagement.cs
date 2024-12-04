using BLL.Services.Supplier;
using BLL.Services.GoodsReceipt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL.Services.Material;
using DTO;
using BLL.Services.GoodsReceiptDetails;
using DAL.Repositories.Category.GoodsReceipt;
using System.Runtime.Remoting.Contexts;
using GUI.Forms.Manager.GoodsReceiptDetails;
using Microsoft.Extensions.DependencyInjection;

namespace GUI.Forms.Manager.GoodsReceipt
{
    public partial class frmGoodsReceiptManagement : Form
    {
        private readonly IGoodsReceiptService _goodsreceiptService;
        private readonly IGoodsReceiptDetailsService _goodsreceiptdetailsService;
        private readonly ISupplierService _supplierService;
        private readonly IMaterialService _materialService;


        public frmGoodsReceiptManagement(IGoodsReceiptService goodsreceiptService, ISupplierService supplierService, IGoodsReceiptDetailsService goodsreceiptdetailsService, IMaterialService materialService)
        {
            this._goodsreceiptService = goodsreceiptService;
            this._supplierService = supplierService;
            this._goodsreceiptdetailsService = goodsreceiptdetailsService;
            this._materialService = materialService;
            InitializeComponent();
            // this.Load += frmGoodsReceiptManagement_Load;
            this.Shown += FrmGoodsReceiptManagement_Shown;
        }
        private void FrmGoodsReceiptManagement_Shown(object sender, EventArgs e)
        {
            // Tải lại dữ liệu mỗi khi form được hiển thị
            LoadGoodsReceiptToDataGridView();
        }

        private void frmGoodsReceiptManagement_Load(object sender, EventArgs e)
        {
            txt_maPhieuNhap.Enabled = false;
            LoadGoodsReceiptToDataGridView();
            dgvGoodsReceipt.CellClick += dgvGoodsReceipt_CellClick;




        }



        private void LoadGoodsReceiptToDataGridView()
        {
            dgvGoodsReceipt.DataSource = _goodsreceiptService.GetData();
            dgvGoodsReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGoodsReceipt.Columns["maPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            dgvGoodsReceipt.Columns["ngayNhapHang"].HeaderText = "Ngày Nhập";
            dgvGoodsReceipt.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp"; 
            dgvGoodsReceipt.Columns["tongTien"].HeaderText = "Tổng Tiền";

            if (dgvGoodsReceipt.Columns.Contains("maNCC"))
                dgvGoodsReceipt.Columns["maNCC"].Visible = false;

        }


        private void dgvGoodsReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGoodsReceipt.Rows[e.RowIndex];

                txt_maPhieuNhap.Text = row.Cells["maPhieuNhap"].Value?.ToString() ?? string.Empty;
              
               
            }
        }




        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập hàng để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieuNhap = txt_maPhieuNhap.Text;

            // Mở form chi tiết
            using (frmGoodsReceiptDetailsManagement detailsForm = new frmGoodsReceiptDetailsManagement(maPhieuNhap, _goodsreceiptdetailsService, _materialService))
            {
                detailsForm.ShowDialog();

                decimal tongTien = detailsForm.CalculateTongTien(); 
                UpdateTongTienInDataGrid(maPhieuNhap, tongTien); 
            }
        }
        private void UpdateTongTienInDataGrid(string maPhieuNhap, decimal tongTien)
        {
            foreach (DataGridViewRow row in dgvGoodsReceipt.Rows)
            {
                if (row.Cells["maPhieuNhap"].Value != null &&
                    row.Cells["maPhieuNhap"].Value.ToString() == maPhieuNhap)
                {
                    row.Cells["tongTien"].Value = tongTien.ToString(); 
                    break;
                }
            }
        }



        private void btn_Insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreategoodsreceiptManagement form = new frmCreategoodsreceiptManagement(_goodsreceiptService, _supplierService, _goodsreceiptdetailsService, _materialService);
            form.ShowDialog();
        }

       
    }
}
    