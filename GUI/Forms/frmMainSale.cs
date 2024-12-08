using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI.Forms
{
    public partial class frmMainSale : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionManager _sessionManager;
        private readonly NhanVien user;
        public frmMainSale(
            IServiceProvider serviceProvider,
            SessionManager sessionManager
            )
        {
            _serviceProvider = serviceProvider;
            _sessionManager = sessionManager;
            user = sessionManager.Staff;
            InitializeComponent();
            this.Load += FrmMainSale_Load;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmMainSale_Load(object sender, EventArgs e)
        {
            
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateOrderSaff frmOrderSaff = _serviceProvider.GetRequiredService<frmCreateOrderSaff>();
            frmOrderSaff.ShowDialog();
            this.Show();
        }

        private void openOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrderManagement frmOrderManagement = _serviceProvider.GetRequiredService<frmOrderManagement>();
            frmOrderManagement.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
