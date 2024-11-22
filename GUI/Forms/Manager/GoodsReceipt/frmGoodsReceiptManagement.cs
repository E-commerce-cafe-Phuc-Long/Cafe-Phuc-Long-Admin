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
using BLL.Services.Category;
using BLL.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL.Services.Material;
using DTO;
using BLL.Services.GoodsReceiptDetails;

namespace GUI.Forms.Manager.GoodsReceipt
{
    public partial class frmGoodsReceiptManagement : Form
    {
        private readonly IGoodsReceiptService _goodsreceiptService;
        private readonly IGoodsReceiptDetailsService _goodsreceiptdetailsService;
        private readonly ISupplierService _supplierService;
        private readonly IMaterialService _materialService;
        public frmGoodsReceiptManagement(IGoodsReceiptService goodsreceiptService, ISupplierService supplierService, IMaterialService materialService, IGoodsReceiptDetailsService goodsreceiptdetailsService)
        {
            this._goodsreceiptService = goodsreceiptService;
            this._supplierService = supplierService;
            this._materialService = materialService;
            this._goodsreceiptdetailsService = goodsreceiptdetailsService; 
            InitializeComponent();
            this.Load += frmGoodsReceiptManagement_Load;
        }


        private void frmGoodsReceiptManagement_Load(object sender, EventArgs e)
        {
            dtp_ngayNhap.Format = DateTimePickerFormat.Custom;
            dtp_ngayNhap.CustomFormat = "dd/MM/yyyy";
            LoadSupplierToComboBox();
            LoadMaterialToComboBox();
            LoadGoodsReceiptToDataGridView();
            dgvGoodsReceipt.CellClick += dgvGoodsReceipt_CellClick;
            txt_soLuong.KeyPress += txt_soLuong_KeyPress;
            txt_donGia.KeyPress += txt_donGia_KeyPress;
            txt_thanhTien.ReadOnly = true;
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
        private void LoadMaterialToComboBox()
        {
            var materials = _materialService.GetMaterialsList();
            comboBox_tenNL.DataSource = materials;
            comboBox_tenNL.DisplayMember = "tenNL"; 
            comboBox_tenNL.ValueMember = "maNL";  
        }

        private void LoadGoodsReceiptToDataGridView()
        {

            var goodsReceiptList = _goodsreceiptService.GetGoodsReceiptList();
            var supplierList = _supplierService.GetSupplierList();
            var goodsReceiptDetailsList = _goodsreceiptdetailsService.GetGoodsReceiptDetailsList();
            var materialList = _materialService.GetMaterialsList();

            var goodsReceiptWithSupplierNames = goodsReceiptList.Select(gr => new
            {
                gr.maPhieuNhap,
                gr.ngayNhapHang,
                gr.maNCC,
                tenNCC = supplierList.FirstOrDefault(sup => sup.maNCC == gr.maNCC)?.tenNCC,
                chiTiet = goodsReceiptDetailsList.Where(grd => grd.maPhieuNhap == gr.maPhieuNhap)
                   .Select(grd => new
                   {
                       grd.maNL,
                       tenNL = materialList.FirstOrDefault(mat => mat.maNL == grd.maNL)?.tenNL,
                       //grd.soLuongNhap,
                       //grd.donGia,
                       //grd.thanhTien  
                   }).ToList()
            }).ToList();

            // Hiển thị dữ liệu lên DataGridView
            dgvGoodsReceipt.DataSource = goodsReceiptWithSupplierNames;
            dgvGoodsReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đặt tên các cột
            dgvGoodsReceipt.Columns["maPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            dgvGoodsReceipt.Columns["ngayNhapHang"].HeaderText = "Ngày Nhập";
            dgvGoodsReceipt.Columns["tenNCC"].HeaderText = "Tên Nhà Cung Cấp";
           // dgvGoodsReceipt.Columns["tongTien"].HeaderText = "Tổng Tiền";
           // dgvGoodsReceipt.Columns["soLuong"].HeaderText = "Số Lượng";
           // dgvGoodsReceipt.Columns["donGia"].HeaderText = "Đơn Giá";

            // Ẩn cột maNCC
            if (dgvGoodsReceipt.Columns.Contains("maNCC"))
                dgvGoodsReceipt.Columns["maNCC"].Visible = false;

            // Đảm bảo cột maNL tồn tại
            //if (!dgvGoodsReceipt.Columns.Contains("maNL"))
            //{
            //    dgvGoodsReceipt.Columns.Add("maNL", "Mã Nguyên Liệu");
            //}
            // Kiểm tra xem có cột thanhTien không, nếu không thêm nó vào
            if (!dgvGoodsReceipt.Columns.Contains("thanhTien"))
            {
                dgvGoodsReceipt.Columns.Add("thanhTien", "Thành Tiền");
            }

            // Ẩn cột "thanhTien"
            dgvGoodsReceipt.Columns["thanhTien"].Visible = false;

            CalculateTongTien();
            CalculateThanhTien();

        }



        private void dgvGoodsReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số hàng hợp lệ (>= 0)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGoodsReceipt.Rows[e.RowIndex];

                txt_maPhieuNhap.Text = row.Cells["maPhieuNhap"].Value?.ToString() ?? string.Empty;

                dtp_ngayNhap.Value = DateTime.TryParse(row.Cells["ngayNhapHang"].Value?.ToString(), out DateTime ngayNhapHang) ? ngayNhapHang : DateTime.Now;


              //  txt_tongTien.Text = row.Cells["tongTien"].Value?.ToString() ?? string.Empty;


                var maNCC = row.Cells["maNCC"].Value?.ToString();
                if (!string.IsNullOrEmpty(maNCC))
                {
                    comboBox_Supplier.SelectedValue = maNCC;
                }


                //var maNL = row.Cells["maNL"]?.Value?.ToString();
                //if (!string.IsNullOrEmpty(maNL))
                //{
                //    comboBox_tenNL.SelectedValue = maNL;
                //}
                //else
                //{
                //    comboBox_tenNL.SelectedIndex = -1;  
                //}

               // txt_soLuong.Text = row.Cells["soLuong"]?.Value?.ToString() ?? string.Empty;

               // txt_donGia.Text = row.Cells["donGia"]?.Value?.ToString() ?? string.Empty;

                CalculateThanhTien();
            }
        }


        void Reset()
        {
            txt_maPhieuNhap.Clear();         
            dtp_ngayNhap.Value = DateTime.Now;
            comboBox_Supplier.SelectedIndex = -1;
            txt_tongTien.Clear();
            LoadGoodsReceiptToDataGridView();
            comboBox_tenNL.SelectedIndex = -1;
            txt_donGia.Clear();
            txt_soLuong.Clear();
            txt_thanhTien.Clear();
        }

        


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

      


        private void CalculateThanhTien()
        {
            if (decimal.TryParse(txt_soLuong.Text, out decimal soLuong) &&
                decimal.TryParse(txt_donGia.Text, out decimal donGia))
            {
                decimal thanhTien = soLuong * donGia;

                txt_thanhTien.Text = Math.Round(thanhTien, 0).ToString("N0");

            }
            else
            {
                txt_thanhTien.Clear();
            }
        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void txt_donGia_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void txt_tongTien_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalculateTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvGoodsReceipt.Rows)
            {
                if (decimal.TryParse(row.Cells["thanhTien"].Value?.ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }

            txt_tongTien.Text = tongTien.ToString("N0");
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var maPhieuNhap = txt_maPhieuNhap.Text.Trim();
            var ngayNhapHang = dtp_ngayNhap.Value;
            var maNCC = comboBox_Supplier.SelectedValue?.ToString(); 
            var soLuong = txt_soLuong.Text.Trim();
            var donGia = txt_donGia.Text.Trim();
            var thanhTien = txt_thanhTien.Text.Trim();

            if (string.IsNullOrEmpty(maPhieuNhap) || string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(soLuong) ||
                string.IsNullOrEmpty(donGia) || string.IsNullOrEmpty(thanhTien))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            PhieuNhap phieuNhap = new PhieuNhap
            {
                maPhieuNhap = maPhieuNhap,
                ngayNhapHang = ngayNhapHang,
                maNCC = maNCC,
                tongTien = decimal.TryParse(txt_tongTien.Text.Trim(), out decimal tongTien) ? tongTien : 0
            };

            List<ChiTietPhieuNhap> chiTietPhieuNhaps = new List<ChiTietPhieuNhap>
    {
        new ChiTietPhieuNhap
        {
            maPhieuNhap = maPhieuNhap,
            maNL = comboBox_tenNL.SelectedValue?.ToString(),
            soLuongNhap = decimal.TryParse(soLuong, out decimal soLuongNhap) ? soLuongNhap : 0,
            donGia = decimal.TryParse(donGia, out decimal donGiaVal) ? donGiaVal : 0,
            thanhTien = decimal.TryParse(thanhTien, out decimal thanhTienVal) ? thanhTienVal : 0
        }
    };

  
            bool result = _goodsreceiptService.InsertGoodsReceipt(phieuNhap, chiTietPhieuNhaps);


            if (result)
            {
                MessageBox.Show("Thêm phiếu nhập thành công.");
                LoadGoodsReceiptToDataGridView();
                Reset(); 
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm phiếu nhập. Vui lòng thử lại.");
            }
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
 }
   