﻿using BLL.Services;
using BLL.Services.Auth;
using BLL.Services.Staff;
using DTO;
using GUI.Forms;
using GUI.Forms.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAuthService _authService;
        private readonly IStaffService _staffService;
        private readonly SessionManager _sessionManager;
        public frmLogin(
            IServiceProvider serviceProvider,
            IAuthService authService,
            IStaffService staffService,
            SessionManager sessionManager
            )
        {
            this._serviceProvider = serviceProvider;
            this._authService = authService;
            this._staffService = staffService;
            this._sessionManager = sessionManager;
            InitializeComponent();
            txtBox_Password.PasswordChar = '*';
            this.Load += FrmLogin_Load;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            panel_Container.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Các sự kiện sau khi load thông tin form
            this.btn_LoginSubmit.Click += Btn_LoginSubmit_Click;
        }

        private void Btn_LoginSubmit_Click(object sender, EventArgs e)
        {
            //Cần xử lý kiểm tra thông tin đăng nhập manager/staff để điều hướng form
            string username = txtBox_Login.Text.Trim();
            string password = txtBox_Password.Text.Trim();

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            
            NhanVien user = _staffService.GetStaffByUsername(username);
            if (user == null)
            {
                MessageBox.Show("Username không hợp lệ!");
                return;
            }
            string hashPassword = user.matKhau;
            bool result = _staffService.VerifyHashedPassword(hashPassword, password);
            if( result == false )
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
                return;
            }

            string role = _authService.getRoleByUsernamePassword(username);

            // Lưu thông tin vào SessionManager
            _sessionManager.Staff = user;

            if (role == "Manager")
            { 
                this.Hide();
                frmMainManagement frmMainManagement = _serviceProvider.GetRequiredService<frmMainManagement>();
                frmMainManagement.ShowDialog();
            }
            else if (role == "Staff")
            {
                this.Hide();
                frmMainSale frmMainSale = _serviceProvider.GetRequiredService<frmMainSale>();
                frmMainSale.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản này không hợp lệ. Vui lòng đăng nhập lại");
            }
        }
    }
}
