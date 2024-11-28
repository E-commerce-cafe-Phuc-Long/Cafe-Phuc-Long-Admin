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

namespace GUI.Forms.Manager.Supplier
{
    public partial class frmSupplierManagement : Form
    {
        private readonly ISupplierService _supplierService;
        public frmSupplierManagement(ISupplierService supplierService)
        {
            this._supplierService = supplierService;
            InitializeComponent();
            this.Load += frmSupplierManagement_Load;
        }
        private void frmSupplierManagement_Load(object sender, EventArgs e)
        {
            txt_maNCC.Enabled = false;
            LoadSupplierToDataGridView();
            dgv_NCC.CellClick += dgv_NCC_CellClick;
        }

        private void LoadSupplierToDataGridView()
        {
            dgv_NCC.DataSource = _supplierService.GetSupplierList();
            dgv_NCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NCC.Columns["maNCC"].HeaderText = "Mã nhà cung cấp";
            dgv_NCC.Columns["tenNCC"].HeaderText = "Tên nhà cung cấp";
            dgv_NCC.Columns["diaChi"].HeaderText = "Địa chỉ";
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            txt_maNCC.Clear();
            txt_tenNCC.Clear();
            txt_diaChi.Clear();
            txt_Search.Clear();
            LoadSupplierToDataGridView();
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NCC.Rows[e.RowIndex];
                txt_maNCC.Text = row.Cells["maNCC"].Value?.ToString() ?? string.Empty;
                txt_tenNCC.Text = row.Cells["tenNCC"].Value?.ToString() ?? string.Empty;
                txt_diaChi.Text = row.Cells["diaChi"].Value?.ToString() ?? string.Empty;
            }

        }


        //Chức năng

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = _supplierService.GenerateCode();

                NhaCungCap ncc = new NhaCungCap
                {
                    maNCC = maNCC,
                    tenNCC = txt_tenNCC.Text,
                    diaChi = txt_diaChi.Text,
                };

                bool result = _supplierService.Insert(ncc);

                if (result)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSupplierToDataGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã cung cấp cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhaCungCap ncc = new NhaCungCap
            {
                maNCC = txt_maNCC.Text,
                tenNCC = txt_tenNCC.Text,
                diaChi = txt_diaChi.Text,
            };

            bool kq = _supplierService.Update(ncc);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSupplierToDataGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, mã nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maNCC= txt_maNCC.Text.Trim();

            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng chọn mã nhà cung cấp để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool kq = _supplierService.Delete(maNCC);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSupplierToDataGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, mã nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();
                var searchResult = _supplierService.Search(keyword);
                dgv_NCC.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
