using BLL.Services;
using BLL.Services.Customer;
using BLL.Services.Dosage;
using BLL.Services.Method;
using BLL.Services.Order;
using BLL.Services.OrderDetail;
using BLL.Services.ProductDetail;
using BLL.Services.Size;
using BLL.Services.Staff;
using BLL.Services.StatusOrder;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;

namespace GUI.Forms
{
    public partial class frmOrderManagement : Form
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMethodService _methodService;
        private readonly ICustomerService _customerService;
        private readonly IStaffService _staffService;
        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;
        private readonly ISizeService _sizeService;
        private readonly IDosageService _dosageService;
        private readonly IStatusOrderService _statusOrderService;
        public frmOrderManagement(
            IOrderService orderService,
            IOrderDetailService orderDetailService,
            IMethodService methodService,
            ICustomerService customerService,
            IStaffService staffService,
            IProductDetailService productDetailService,
            IProductService productService,
            ISizeService sizeService,
            IDosageService dosageService,
            IStatusOrderService statusOrderService
            )
        {
            this._orderService = orderService;
            this._orderDetailService = orderDetailService;
            this._methodService = methodService;
            this._customerService = customerService;
            this._staffService = staffService;
            this._productDetailService = productDetailService;
            this._productService = productService;
            this._sizeService = sizeService;
            this._dosageService = dosageService;
            this._statusOrderService = statusOrderService;
            InitializeComponent();
            this.Load += FrmOrderManagement_Load;
        }

        private void FrmOrderManagement_Load(object sender, EventArgs e)
        {
            // Call the method to display the list of orders in the ListBox
            DisplayOrderList();
            listView_OrderDetailList_Config();
            var orderDetails = _orderDetailService.GetOrderDetailsList();
            LoadOrderDetailsToListView(orderDetails);
            loadDataComboBox();
        }

        private void DisplayOrderList()
        {
            var orders = _orderService.GetOrdersList();
            listBox_order.DataSource = null;
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
            listView_orderDetailsList.Columns.Add("Sản phẩm", 200);
            listView_orderDetailsList.Columns.Add("kích cỡ", 100);
            listView_orderDetailsList.Columns.Add("Ngọt", 100);
            listView_orderDetailsList.Columns.Add("Đá", 100);
            listView_orderDetailsList.Columns.Add("Trà", 100);
            listView_orderDetailsList.Columns.Add("Số lượng", 100);
            listView_orderDetailsList.Columns.Add("Đơn giá",100);
            listView_orderDetailsList.Columns.Add("Thành tiền", 200);
        }
        private void LoadOrderDetailsToListView(List<ChiTietDonHang> orderDetails)
        {
            listView_orderDetailsList.Items.Clear();
            
            foreach (ChiTietDonHang orderDetail in orderDetails)
            {
                string code = orderDetail.maCTSP;
                ChiTietSanPham ProductDetail = _productDetailService.GetProductDetailByCode(code);
                string nameProduct = _productService.GetProductByCode(ProductDetail.maSP).tenSP;
                string nameSize = _sizeService.GetSizeByCode(ProductDetail.maSize).tenSize;
                string nameDosage1 = _dosageService.Get(orderDetail.lieuLuongNgot).tenLL;
                string nameDosage2 = _dosageService.Get(orderDetail.lieuLuongDa).tenLL;
                string nameDosage3 = _dosageService.Get(orderDetail.lieuLuongTra).tenLL;
                ListViewItem item = new ListViewItem(nameProduct);
                item.SubItems.Add(nameSize);
                item.SubItems.Add(nameDosage1);
                item.SubItems.Add(nameDosage2);
                item.SubItems.Add(nameDosage3);
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

            LoadOrderDetailsToListView(orderDetails);
            SelectInComboBox(order.maKH, order.maPT, order.maNV, order.maTT);
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
            List<TrangThai_DH> trangThai_DHs = _statusOrderService.GetStatusOrdersList();
            comboBox_status.DataSource = trangThai_DHs;
            comboBox_status.DisplayMember = "tenTT";
            comboBox_status.ValueMember = "maTT";
            List<TrangThai_DH> trangThai_DHs1 = _statusOrderService.GetStatusOrdersList();
            trangThai_DHs1.Insert(0, new TrangThai_DH { maTT = "all", tenTT = "Tất cả" });
            comboBox_StatusOrder.DataSource = trangThai_DHs1;
            comboBox_StatusOrder.DisplayMember = "tenTT";
            comboBox_StatusOrder.ValueMember = "maTT";
        }
        private void SelectInComboBox(string maKH, string maPT, string maNV, string maTT)
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
            if (maKH != null)
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
            if (maTT != null)
            {
                
                foreach (var item in comboBox_status.Items)
                {
                    var tt = item as TrangThai_DH;

                    if (tt != null && tt.maTT == maTT)
                    {
                        comboBox_status.SelectedItem = item;
                        break;
                    }
                }
                
            }
        }

        private void btn_updateStatus_Click(object sender, EventArgs e)
        {
            if (listBox_order.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật trạng thái");
                return;
            }
            var order = (DonHang)listBox_order.SelectedItem;
            var status = (TrangThai_DH)comboBox_status.SelectedItem;
            if (order.maTT == "TTDH003")
            {
                MessageBox.Show("Đơn hàng đã hoàn thành không thể cập nhật trạng thái");
                return;
            }
            if(_orderService.UpdateStatusOrder(order.maDH, status.maTT))
            {
                MessageBox.Show("Cập nhật trạng thái thành công", status.maTT);
                DisplayOrderList();
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại");
            }

            DisplayOrderList();
        }

        private void comboBox_StatusOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var status = (TrangThai_DH)comboBox_StatusOrder.SelectedItem;
            
            if (status.maTT == "all")
            {
                DisplayOrderList();
                return;
            }
            var orders = _orderService.GetOrdersListByTT(status.maTT);
            listBox_order.DataSource = null;
            listBox_order.DataSource = orders;
            listBox_order.DisplayMember = "maDH";
            listBox_order.ValueMember = "maDH";

        }
    }
}
