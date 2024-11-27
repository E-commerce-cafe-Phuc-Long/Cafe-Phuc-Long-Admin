using BLL.Services;
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
        public frmLogin(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Các sự kiện sau khi load thông tin form
            this.btn_LoginSubmit.Click += Btn_LoginSubmit_Click;
        }

        private void Btn_LoginSubmit_Click(object sender, EventArgs e)
        {
            //Cần xử lý kiểm tra thông tin đăng nhập manager/staff để điều hướng form
            this.Hide();
            frmMainSale frmMainSale = _serviceProvider.GetRequiredService<frmMainSale>();
            frmMainSale.ShowDialog();

            //frmMainManagement frmMainManagement = _serviceProvider.GetRequiredService<frmMainManagement>();
            //frmMainManagement.ShowDialog();
            //Cần xử lý ngoại lệ, thông báo lỗi đăng nhập
        }
    }
}
