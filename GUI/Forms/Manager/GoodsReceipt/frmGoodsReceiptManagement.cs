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
            this.Load += frmGoodsReceiptManagement_Load;
        }


        private void frmGoodsReceiptManagement_Load(object sender, EventArgs e)
        {
            dtp_ngayNhap.Format = DateTimePickerFormat.Custom;
            dtp_ngayNhap.CustomFormat = "dd/MM/yyyy";
            LoadSupplierToComboBox();
            LoadGoodsReceiptToDataGridView();
            dgvGoodsReceipt.CellClick += dgvGoodsReceipt_CellClick;
            txt_tongTien.ReadOnly = true;
            Reset();

        }
        private void LoadSupplierToComboBox()
        {
            var roles = _supplierService.GetSupplierList();
            comboBox_Supplier.DataSource = roles;
            comboBox_Supplier.DisplayMember = "tenNCC";
            comboBox_Supplier.ValueMember = "maNCC";

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
                dtp_ngayNhap.Value = DateTime.TryParse(row.Cells["ngayNhapHang"].Value?.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                var maNCC = row.Cells["maNCC"].Value?.ToString();
                if (!string.IsNullOrEmpty(maNCC))
                {
                    comboBox_Supplier.SelectedValue = maNCC;
                }
                txt_tongTien.Text = row.Cells["tongTien"].Value?.ToString() ?? string.Empty;
               
            }
        }
        void Reset()
        {
            txt_maPhieuNhap.Clear();         
            dtp_ngayNhap.Value = DateTime.Now;
            comboBox_Supplier.SelectedIndex = -1;
            txt_tongTien.Clear();
            LoadGoodsReceiptToDataGridView();                                                                                                                 
            txt_Search.Clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string keyword = txt_Search.Text.Trim();
            //    dgvGoodsReceipt.DataSource = _goodsreceiptService.Search(keyword);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập hàng để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maPhieuNhap = txt_maPhieuNhap.Text;
            frmGoodsReceiptDetailsManagement detailsForm = new frmGoodsReceiptDetailsManagement(maPhieuNhap,_supplierService, _goodsreceiptdetailsService,_materialService);
            detailsForm.ShowDialog();

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
    