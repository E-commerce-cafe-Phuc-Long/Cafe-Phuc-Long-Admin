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
        private readonly IGoodsReceiptDetailsService _goodsReceiptDetailsService;
        private readonly IMaterialService _materialService;


        public frmGoodsReceiptDetailsManagement(string maPhieuNhap, IGoodsReceiptDetailsService goodsReceiptDetailsService, IMaterialService materialService)
        { 
            this._maPhieuNhap = maPhieuNhap;
            this._goodsReceiptDetailsService = goodsReceiptDetailsService;
            this._materialService = materialService;
            InitializeComponent();
            this.Load += frmGoodsReceiptDetailsManagement_Load;
        }

        private void frmGoodsReceiptDetailsManagement_Load(object sender, EventArgs e)
        {
            txt_maPhieuNhap.Text = _maPhieuNhap;
            txt_maPhieuNhap.Enabled = false;
            txt_tongTien.Enabled = false;
            txt_tongSoLuong.Enabled = false;
       
            LoadDetails();

        }


        private void LoadDetails()
        {
         
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



        public decimal CalculateTongTien()
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
            return tongTien; 
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
    
