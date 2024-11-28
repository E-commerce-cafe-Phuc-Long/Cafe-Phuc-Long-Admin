using BLL.Services.Staff;
using BLL.Services.Role;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Net.NetworkInformation;


namespace GUI.Forms.Manager.Staff
{
    public partial class frmStaffManagement : Form
    {
        private readonly IStaffService _staffService;
        private readonly IRoleService _roleService;

        public frmStaffManagement(IStaffService staffService, IRoleService roleService)
        {
            _staffService = staffService ?? throw new ArgumentNullException(nameof(staffService));
            _roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
            InitializeComponent();
            this.Load += FrmStaffManagement_Load;
        }

        private void FrmStaffManagement_Load(object sender, EventArgs e)
        {
            txt_maNV.Enabled = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            LoadRoleToComboBox();
            LoadStaffToDataGridView();
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            Reset();
        }

        private void LoadRoleToComboBox()
        {
            var roles = _roleService.GetRoleList();
            comboBox_Role.DataSource = roles;
            comboBox_Role.DisplayMember = "tenVaiTro";
            comboBox_Role.ValueMember = "maVaiTro";
        }

        private void LoadStaffToDataGridView()
        {

            dgvNhanVien.DataSource = _staffService.GetStaffWithRoleNames();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvNhanVien.Columns["maNV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["username"].HeaderText = "Tên Đăng Nhập";
            dgvNhanVien.Columns["matKhau"].HeaderText = "Mật Khẩu";
            dgvNhanVien.Columns["tenNV"].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["soDT"].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["email"].HeaderText = "Email";
            dgvNhanVien.Columns["maVaiTro"].Visible = false;
            dgvNhanVien.Columns["tenVaiTro"].HeaderText = "Vai Trò";

           
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txt_maNV.Text = row.Cells["maNV"].Value?.ToString() ?? string.Empty;
                txt_username.Text = row.Cells["username"].Value?.ToString() ?? string.Empty;
                txt_password.Text = row.Cells["matKhau"].Value?.ToString() ?? string.Empty;
                txt_tenNV.Text = row.Cells["tenNV"].Value?.ToString() ?? string.Empty;
                dtpNgaySinh.Value = DateTime.TryParse(row.Cells["ngaySinh"].Value?.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                txt_soDT.Text = row.Cells["soDT"].Value?.ToString() ?? string.Empty;
                txt_email.Text = row.Cells["diaChi"].Value?.ToString() ?? string.Empty;
                txt_diaChi.Text = row.Cells["email"].Value?.ToString() ?? string.Empty;

                var roleId = row.Cells["maVaiTro"].Value?.ToString();
                if (!string.IsNullOrEmpty(roleId))
                {
                    comboBox_Role.SelectedValue = roleId;
                }
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
               
                string maNV1 = _staffService.GenerateStaffCode();

                NhanVien nv = new NhanVien
                {
                    maNV = maNV1,
                    username = txt_username.Text,
                    matKhau = txt_password.Text,
                    tenNV = txt_tenNV.Text,
                    ngaySinh = dtpNgaySinh.Value,
                    soDT = txt_soDT.Text,
                    diaChi = txt_email.Text,
                    email = txt_diaChi.Text,
                    maVaiTro = comboBox_Role.SelectedValue?.ToString()
                };

                bool result = _staffService.InsertStaff(nv);

                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffToDataGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maNhanVien = txt_maNV.Text.Trim();

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool kq = _staffService.DeleteStaff(maNhanVien);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffToDataGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, mã nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien nv = new NhanVien
            {
                maNV = txt_maNV.Text,
                username = txt_username.Text,
                matKhau = txt_password.Text,
                tenNV = txt_tenNV.Text,
                ngaySinh = dtpNgaySinh.Value,
                soDT = txt_soDT.Text,
                diaChi = txt_email.Text,
                email = txt_diaChi.Text,
                maVaiTro = comboBox_Role.SelectedValue?.ToString()
            };

            bool kq = _staffService.UpdateStaff(nv);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffToDataGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, mã nhân viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            txt_maNV.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_tenNV.Clear();
            txt_soDT.Clear();
            txt_email.Clear();
            txt_diaChi.Clear();
            comboBox_Role.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            txt_Search.Clear();
            LoadStaffToDataGridView();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();
                var searchResult = _staffService.SearchStaff(keyword);
                dgvNhanVien.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }


}