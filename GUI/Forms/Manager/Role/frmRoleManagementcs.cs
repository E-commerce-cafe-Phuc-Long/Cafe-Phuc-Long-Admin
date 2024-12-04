using BLL.Services.Role;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms.Manager.Role
{
    public partial class frmRoleManagement : Form
    {
        private readonly IRoleService _roleService;
        public frmRoleManagement(IRoleService roleService)
        {
            this._roleService = roleService;
            InitializeComponent();
            this.Load += frmRoleManagement_Load;
        }

 
        private void frmRoleManagement_Load(object sender, EventArgs e)
        { 
            LoadRoleToDataGridView();
            dgv_VaiTro.CellClick += dgv_VaiTro_CellClick;
        }

        private void LoadRoleToDataGridView()
        {
            dgv_VaiTro.DataSource = _roleService.GetRoleList();
            dgv_VaiTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_VaiTro.Columns["maVaiTro"].HeaderText = "Mã vai trò";
            dgv_VaiTro.Columns["tenVaiTro"].HeaderText = "Tên vài trò";

        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            txt_maVaiTro.Clear();
            txt_tenVaiTro.Clear();
            LoadRoleToDataGridView();
        }

        private void dgv_VaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_VaiTro.Rows[e.RowIndex];
                txt_maVaiTro.Text = row.Cells["maVaiTro"].Value?.ToString() ?? string.Empty;
                txt_tenVaiTro.Text = row.Cells["tenVaitro"].Value?.ToString() ?? string.Empty;
            }

        }


        //Chức năng

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {

                string maVaiTro = txt_tenVaiTro.Text.Trim() ;

                VaiTro vaitro = new VaiTro
                {
                    maVaiTro = maVaiTro,
                    tenVaiTro = txt_tenVaiTro.Text
                };

                bool result = _roleService.Insert(vaitro);

                if (result)
                {
                    MessageBox.Show("Thêm vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoleToDataGridView();
                    
                }
                else
                {
                    MessageBox.Show("Thêm vai trò thất bại. Có thể vai trò đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string maVaiTro = txt_maVaiTro.Text;

            if (string.IsNullOrWhiteSpace(txt_maVaiTro.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mã vai trò cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            VaiTro vaiTro = new VaiTro
            {
                maVaiTro = maVaiTro,
                tenVaiTro = txt_tenVaiTro.Text
            };

            bool kq = _roleService.Update(vaiTro);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoleToDataGridView();
                
            }
            else
            {
                MessageBox.Show("Sửa thất bại, mã vai trò không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maVaiTro = txt_maVaiTro.Text.Trim();

            if (string.IsNullOrEmpty(maVaiTro))
            {
                MessageBox.Show("Vui lòng chọn mã vai trò để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = _roleService.Delete(maVaiTro);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoleToDataGridView();
                    
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, mã vai trò không tồn tại hoặc đã được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

   
    }


}

