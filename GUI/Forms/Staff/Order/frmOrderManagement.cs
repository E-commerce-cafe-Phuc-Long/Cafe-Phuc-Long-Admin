using BLL.Services.Customer;
using BLL.Services.Method;
using BLL.Services.Order;
using BLL.Services.OrderDetail;
using BLL.Services.Staff;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GUI.Forms
{
    public partial class frmOrderManagement : Form
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMethodService _methodService;
        private readonly ICustomerService _customerService;
        private readonly IStaffService _staffService;


        public frmOrderManagement(
            IOrderService orderService,
            IOrderDetailService orderDetailService,
            IMethodService methodService,
            ICustomerService customerService,
            IStaffService staffService
            )
        {
            this._orderService = orderService;
            this._orderDetailService = orderDetailService;
            this._methodService = methodService;
            this._customerService = customerService;
            this._staffService = staffService;
            InitializeComponent();
            this.Load += FrmOrderManagement_Load;
        }

        private void FrmOrderManagement_Load(object sender, EventArgs e)
        {
            // Call the method to display the list of orders in the ListBox
            DisplayOrderList();
            listView_OrderDetailList_Config();
            LoadOrderDetailsToListView();
            loadDataComboBox();
        }

        private void DisplayOrderList()
        {
            var orders = _orderService.GetOrdersList();

            listBox_order.Items.Clear();
            listBox_order.DataSource = orders;
            listBox_order.DisplayMember = "maDH";
            listBox_order.ValueMember = "maDH";
        }
        private void listView_OrderDetailList_Config()
        {
            listView_orderDetailsList.View = View.Details;
            listView_orderDetailsList.FullRowSelect = true;
            listView_orderDetailsList.GridLines = true;
            listView_orderDetailsList.MultiSelect = false;
            listView_orderDetailsList.Items.Clear();
            listView_orderDetailsList.Columns.Add("Mã chi tiết đơn hàng", 100);
            listView_orderDetailsList.Columns.Add("Số lượng", 100);
            listView_orderDetailsList.Columns.Add("Đơn giá",100);
            listView_orderDetailsList.Columns.Add("Thành tiền", 200);
        }
        private void LoadOrderDetailsToListView()
        {
            listView_orderDetailsList.Items.Clear();
            var orderDetails = _orderDetailService.GetOrderDetailsList();
            foreach (ChiTietDonHang orderDetail in orderDetails)
            {
                ListViewItem item = new ListViewItem(orderDetail.maCTSP);
                item.SubItems.Add(orderDetail.soLuongDatHang.ToString());
                item.SubItems.Add(orderDetail.donGia.ToString());
                item.SubItems.Add(orderDetail.thanhTien.ToString());
                item.Tag = orderDetail;

                listView_orderDetailsList.Items.Add(item);
            }
        }

        private void listBox_order_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox_order.SelectedItem == null)
            {
                return;
            }

            var order = (DonHang)listBox_order.SelectedItem;
            var orderDetails = _orderDetailService.GetOrderDetailsListByOrderCode(order.maDH);

            listView_orderDetailsList.Items.Clear();

            foreach (ChiTietDonHang orderDetail in orderDetails)
            {
                ListViewItem item = new ListViewItem(orderDetail.maCTSP);
                item.SubItems.Add(orderDetail.soLuongDatHang.ToString());
                item.SubItems.Add(orderDetail.donGia.ToString());
                item.SubItems.Add(orderDetail.thanhTien.ToString());
                item.Tag = orderDetail;

                listView_orderDetailsList.Items.Add(item);
            }
            SelectInComboBox(order.maKH, order.maPT, order.maNV);
            txt_total.Text = order.tongTien.ToString();
            txt_note.Text = order.ghiChu;
            dtp_ngayLapHD.Value = order.ngayLapDH ?? DateTime.Now;
        }
        private void loadDataComboBox()
        {
            List<PhuongThucThanhToan> methods = _methodService.GetMethodsList();
            comboBox_method.DataSource = methods;
            comboBox_method.DisplayMember = "TenPT";
            comboBox_method.ValueMember = "MaPT";
            List<KhachHang> khs = _customerService.GetCustomersList();
            comboBox_customer.DataSource = khs;
            comboBox_customer.DisplayMember = "tenKH";
            comboBox_customer.ValueMember = "maKH";
            List<NhanVien> nvs = _staffService.GetStaffList();
            comboBox_staff.DataSource = nvs;
            comboBox_staff.DisplayMember = "tenNV";
            comboBox_staff.ValueMember = "maNV";

        }
        private void SelectInComboBox(string maKH, string maPT, string maNV)
        {
            foreach (var item in comboBox_method.Items)
            {
                var PTTT = item as PhuongThucThanhToan;
                if (PTTT != null && PTTT.maPT == maPT)
                {
                    comboBox_method.SelectedItem = item;
                    break;
                }
            }
            if(maKH != null)
            {
                foreach (var item in comboBox_customer.Items)
                {
                    var kh = item as KhachHang;
                    if (kh != null && kh.maKH == maKH)
                    {
                        comboBox_customer.SelectedItem = item;
                        break;
                    }
                }
            }
            if (maNV != null)
            {
                foreach (var item in comboBox_staff.Items)
                {
                    var nv = item as NhanVien;
                    if (nv != null && nv.maNV == maNV)
                    {
                        comboBox_staff.SelectedItem = item;
                        break;
                    }
                }
            }
            
        }
    }
}
