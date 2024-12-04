using BLL.Services;
using GUI.Forms.Manager.GoodsReceipt;
using GUI.Forms.Manager.Supplier;
using GUI.Forms.Manager.Staff;
using GUI.Forms.Manager.Customer;
using GUI.Forms.Manager.Role;
using GUI.Forms.Manager.Report;
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
using DTO;
using GUI.Forms.Manager.Account;

namespace GUI.Forms.Manager
{
    public partial class frmMainManagement : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionManager _sessionManager;
        private readonly NhanVien user;
        public frmMainManagement(
            IServiceProvider serviceProvider,
            SessionManager sessionManager
            )
        {
            _serviceProvider = serviceProvider;
            _sessionManager = sessionManager;
            user = sessionManager.Staff;
            InitializeComponent();
            this.Load += FrmMainManagement_Load;
        }

        private void FrmMainManagement_Load(object sender, EventArgs e)
        {
            // Các sự kiện sau khi load thông tin form
            this.viewProductToolStripMenuItem.Click += ViewProductToolStripMenuItem_Click;
            this.ViewMaterialToolStripMenuItem.Click += ViewMaterialToolStripMenuItem_Click;
        }

        private void ViewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductManagement frmProductManagement = _serviceProvider.GetRequiredService<frmProductManagement>();
            frmProductManagement.ShowDialog();
            this.Show();
        }
        private void ViewMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMaterialManagement frmMaterialManagement = _serviceProvider.GetRequiredService<frmMaterialManagement>();
            frmMaterialManagement.ShowDialog();
            this.Show();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmCustomerManagement frmCustomerManagement = _serviceProvider.GetRequiredService<frmCustomerManagement>();
            //frmCustomerManagement.ShowDialog();
            //this.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffManagement frmStaffManagement = _serviceProvider.GetRequiredService<frmStaffManagement>();
            frmStaffManagement.ShowDialog();
            this.Show();
        }

        private void viewGoodsReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGoodsReceiptManagement frmGoodsReceiptManagement = _serviceProvider.GetRequiredService<frmGoodsReceiptManagement>();
            frmGoodsReceiptManagement.ShowDialog();
            this.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCustomerManagement FrmCustomerManagement = _serviceProvider.GetRequiredService<FrmCustomerManagement>();
            FrmCustomerManagement.ShowDialog();
            this.Show();
        }

        private void viewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplierManagement frmSupplierManagement= _serviceProvider.GetRequiredService<frmSupplierManagement>();
            frmSupplierManagement.ShowDialog();
            this.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoleManagement frmRoleManegement = _serviceProvider.GetRequiredService<frmRoleManagement>();
            frmRoleManegement.ShowDialog();
            this.Show();
        }

       

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportManagement frmReportManegement = _serviceProvider.GetRequiredService<frmReportManagement>();
            frmReportManegement.ShowDialog();
            this.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountManagement frmAccountManegement = _serviceProvider.GetRequiredService<frmAccountManagement>();
            frmAccountManegement.ShowDialog();
            this.Show();
        }
    }
}
