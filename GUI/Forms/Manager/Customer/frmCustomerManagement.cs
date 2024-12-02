using BLL.Services.Customer;
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

namespace GUI.Forms.Manager.Customer
{
    public partial class FrmCustomerManagement : Form
    {
        private readonly ICustomerService _customerService;

        public FrmCustomerManagement(ICustomerService customerService)
        {
            this._customerService = customerService;
            InitializeComponent();
            //  this.Load += FrmCustomerManagement_Load;
        }

        private void FrmCustomerManagement_Load(object sender, EventArgs e)
        {
            txt_maKH.Enabled = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            LoadCustomerToDataGridView();
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            Reset();
        }




        private void LoadCustomerToDataGridView()
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dgvKhachHang.DataSource = _customerService.GetCustomersList();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvKhachHang.Columns["maKH"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["username"].Visible = false;
            dgvKhachHang.Columns["matKhau"].Visible = false;
            dgvKhachHang.Columns["tenKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvKhachHang.Columns["soDT"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns["email"].HeaderText = "Email";    
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txt_maKH.Text = row.Cells["maKH"].Value?.ToString() ?? string.Empty;
                txt_tenKH.Text = row.Cells["tenKH"].Value?.ToString() ?? string.Empty;
                dtpNgaySinh.Value = DateTime.TryParse(row.Cells["ngaySinh"].Value?.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                txt_soDT.Text = row.Cells["soDT"].Value?.ToString() ?? string.Empty;
                txt_email.Text = row.Cells["diaChi"].Value?.ToString() ?? string.Empty;
                txt_diaChi.Text = row.Cells["email"].Value?.ToString() ?? string.Empty;              
            }
        }

       

        //private void btn_Insert_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(txt_maNV.Text))
        //        {
        //            MessageBox.Show("Mã nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        NhanVien nv = new NhanVien
        //        {
        //            maNV = txt_maNV.Text,
        //            username = txt_username.Text,
        //            matKhau = txt_password.Text,
        //            tenNV = txt_tenNV.Text,
        //            ngaySinh = dtpNgaySinh.Value,
        //            soDT = txt_soDT.Text,
        //            diaChi = txt_email.Text,
        //            email = txt_diaChi.Text,
        //            maVaiTro = comboBox_Role.SelectedValue?.ToString()
        //        };

        //        bool result = _staffService.InsertStaff(nv);

        //        if (result)
        //        {
        //            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LoadStaffToDataGridView();
        //            Reset();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            txt_maKH.Clear();
            // txt_username.Clear();
            // txt_password.Clear();
            txt_tenKH.Clear();
            txt_soDT.Clear();
            txt_email.Clear();
            txt_diaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txt_Search.Clear();
            LoadCustomerToDataGridView();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang
            {
                maKH = txt_maKH.Text,
                // username = txt_username.Text,
                // matKhau = txt_password.Text,
                tenKH = txt_tenKH.Text,
                ngaySinh = dtpNgaySinh.Value,
                soDT = txt_soDT.Text,
                diaChi = txt_email.Text,
                email = txt_diaChi.Text,
            };

            bool kq = _customerService.UpdateCustomer(kh);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerToDataGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, mã nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            string maKH = txt_maKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool kq = _customerService.DeleteCustomer(maKH);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerToDataGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, mã nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadCustomerToDataGridView();
                    return;
                }

                var searchResult = _customerService.SearchCustomer(keyword);

                if (searchResult != null && searchResult.Any())
                {

                    dgvKhachHang.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKhachHang.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();
                var searchResult = _customerService.SearchCustomer(keyword);
                dgvKhachHang.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}




       
    

