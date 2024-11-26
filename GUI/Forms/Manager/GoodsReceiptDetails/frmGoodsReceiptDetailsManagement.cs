using BLL.Services.GoodsReceiptDetails;
using BLL.Services.Material;
using BLL.Services.Supplier;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms.Manager.GoodsReceiptDetails
{
    public partial class frmGoodsReceiptDetailsManagement : Form
    {
        private readonly string _maPhieuNhap;
        private readonly ISupplierService _supplierService;
        private readonly IGoodsReceiptDetailsService _goodsReceiptDetailsService;
        private readonly IMaterialService _materialService;


        public frmGoodsReceiptDetailsManagement(string maPhieuNhap,ISupplierService supplierService, IGoodsReceiptDetailsService goodsReceiptDetailsService, IMaterialService materialService)
        { 
            this._maPhieuNhap = maPhieuNhap;
            this._supplierService = supplierService;
            this._goodsReceiptDetailsService = goodsReceiptDetailsService;
            this._materialService = materialService;
            InitializeComponent();
            this.Load += frmGoodsReceiptDetailsManagement_Load;
        }

        private void frmGoodsReceiptDetailsManagement_Load(object sender, EventArgs e)
        {
            txt_maPhieuNhap.Text = _maPhieuNhap;
            txt_tongTien.ReadOnly = true;
            dgv_Detail.CellClick += dgv_Detail_CellClick;
            LoadDetails();

        }


        private void LoadDetails()
        {
            LoadMaterialToComboBox();
            var details = _goodsReceiptDetailsService.GetDetailsByGoodsReceiptId(_maPhieuNhap);

            if (dgv_Detail.Columns.Contains("STT"))
            {
                dgv_Detail.Columns.Remove("STT");
            }

            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50
            };
            dgv_Detail.Columns.Insert(0, sttColumn);

            dgv_Detail.DataSource = details;

            dgv_Detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Detail.Columns["MaNL"].Visible = false;
            dgv_Detail.Columns["tenNL"].HeaderText = "Tên Nguyên Liệu";
            dgv_Detail.Columns["SoLuongNhap"].HeaderText = "Số Lượng Nhập";
            dgv_Detail.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgv_Detail.Columns["ThanhTien"].HeaderText = "Thành Tiền";

            for (int i = 0; i < dgv_Detail.Rows.Count; i++)
            {
                dgv_Detail.Rows[i].Cells["STT"].Value = i + 1;
            }
            CountUniqueMaterials();
            CalculateTongTien();
        }

            private void LoadMaterialToComboBox()
        {
            var roles = _materialService.GetMaterialsList();
            comboBox_tenNL.DataSource = roles;
            comboBox_tenNL.DisplayMember = "tenNL";
            comboBox_tenNL.ValueMember = "maNL";

        }

        private void dgv_Detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Detail.Rows[e.RowIndex];

                txt_soLuong.Text = row.Cells["soLuongNhap"].Value?.ToString() ?? string.Empty;
                txt_donGia.Text = row.Cells["donGia"].Value?.ToString() ?? string.Empty;
                txt_thanhTien.Text = row.Cells["ThanhTien"].Value?.ToString() ?? string.Empty;


            }
        }
        private void Reset()
        {
            comboBox_tenNL.SelectedIndex = -1;
            txt_soLuong.Clear();
            txt_donGia.Clear();
            txt_thanhTien.Clear();
            txt_tongTien.Clear();
            LoadDetails();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }


        //Tính toán

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress(e);
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress(e);
        }

        private void ValidateKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTienLocal();
        }
  
        private void CalculateThanhTienLocal()
        {
            if (decimal.TryParse(txt_soLuong.Text, out decimal soLuong) &&
                decimal.TryParse(txt_donGia.Text, out decimal donGia))
            {
                decimal thanhTien = soLuong * donGia;
                txt_thanhTien.Text = thanhTien.ToString();
            }
            else
            {
                txt_thanhTien.Text = "0";
            }
        }
        private void CalculateTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgv_Detail.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null &&
                    decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }

            txt_tongTien.Text = tongTien.ToString(); 
        }

        private void CountUniqueMaterials()
        {
            HashSet<string> uniqueMaterials = new HashSet<string>();

            foreach (DataGridViewRow row in dgv_Detail.Rows)
            {
                if (row.Cells["maNL"].Value != null)
                {
                    string maNL = row.Cells["maNL"].Value.ToString();
                    uniqueMaterials.Add(maNL);
                }
            }
            txt_tongSoLuong.Text = uniqueMaterials.Count.ToString();
        }











    }

}
    
