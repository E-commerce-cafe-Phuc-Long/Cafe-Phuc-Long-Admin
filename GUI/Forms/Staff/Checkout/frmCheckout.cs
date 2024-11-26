using BLL.Services.Method;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Forms
{
    public partial class frmCheckout : Form
    {
        private readonly IMethodService _methodService;
        public frmCheckout(IMethodService methodService)
        {
            this._methodService = methodService;
            InitializeComponent();
            this.Load += FrmCheckout_Load;
        }
        public void SetListViewData(System.Windows.Forms.ListView.ListViewItemCollection items)
        {
            foreach (ListViewItem item in items)
            {
                listView_cart.Items.Add((ListViewItem)item.Clone());
            }
        }
        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            listView_ProductList_Config();
            loadDataComboBox();
            lb_cus.Hide();
            lb_customer.Hide();
        }
        private void listView_ProductList_Config()
        {
            listView_cart.View = View.Details;
            listView_cart.FullRowSelect = true;
            listView_cart.GridLines = true;
            listView_cart.MultiSelect = false;
            listView_cart.Columns.Add("Tên sản phẩm", 200);
            listView_cart.Columns.Add("Số lượng", 100);
            listView_cart.Columns.Add("Size", 100);
            listView_cart.Columns.Add("Đá", 100);
            listView_cart.Columns.Add("Đường", 100);
            listView_cart.Columns.Add("Trà", 100);
            listView_cart.Columns.Add("Giá", 200);
        }
        private void loadDataComboBox()
        {
            List<PhuongThucThanhToan> methods = _methodService.GetMethodsList();
            comboBox_method.DataSource = methods;
            comboBox_method.DisplayMember = "TenPT";
            comboBox_method.ValueMember = "MaPT";
        }
    }
}
