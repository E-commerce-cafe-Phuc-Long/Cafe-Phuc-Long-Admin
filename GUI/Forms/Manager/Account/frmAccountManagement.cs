using BLL.Services.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.Forms.Manager.Account
{
    public partial class frmAccountManagement : Form
    {
        private readonly IAccountService _accountService;
        public frmAccountManagement(IAccountService accountService)
        {
            this._accountService = accountService;
            InitializeComponent();
        }
        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            LoadAccountToDataGridView();
        }
   
        private void LoadAccountToDataGridView()
        {
          
            dgv_taiKhoan.DataSource = _accountService.GetAccountsInfo();
            dgv_taiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_taiKhoan.Columns["userName"].HeaderText = "Username";
            dgv_taiKhoan.Columns["Password"].Visible = false;
            dgv_taiKhoan.Columns["Email"].HeaderText = "Email";
            dgv_taiKhoan.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
          
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();
                var searchResult = _accountService.SearchAccountsByPhoneOrEmail(keyword);
                dgv_taiKhoan.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
