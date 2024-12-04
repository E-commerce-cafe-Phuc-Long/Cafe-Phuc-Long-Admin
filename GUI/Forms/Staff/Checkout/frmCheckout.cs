using BLL.Services;
using BLL.Services.Customer;
using BLL.Services.Method;
using BLL.Services.Order;
using BLL.Services.OrderDetail;
using BLL.Services.ProductDetail;
using BLL.Services.Staff;
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


namespace GUI.Forms
{
    public partial class frmCheckout : Form
    {
        private readonly IMethodService _methodService;
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;

        private readonly SessionManager _sessionManager;
        private NhanVien user;
        public frmCheckout(IMethodService methodService, ICustomerService customerService, 
            IOrderService orderService, IProductDetailService productDetailService,
            IProductService productService, IOrderDetailService orderDetailService,
            SessionManager sessionManager
)
        {
            this._methodService = methodService;
            this._customerService = customerService;
            this._orderService = orderService;
            this._productDetailService = productDetailService;
            this._productService = productService;
            this._orderDetailService = orderDetailService;
            this._sessionManager = sessionManager;
            this.user = sessionManager.Staff;
           
            InitializeComponent();
            this.Load += FrmCheckout_Load;
            btn_search.Click += Btn_search_Click;
        }
        
        private void Btn_search_Click(object sender, EventArgs e)
        {
            string sdt = txt_customer.Text;
            if (sdt == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                return;
            }
            KhachHang kh = _customerService.GetCustomerByPhone(sdt);
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
                return;
            }
            lb_cus.Text = kh.tenKH;
            lb_cus.Show();
            lb_customer.Show();
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
            lb_totalPrice.Text = totalPrice().ToString("#,###");
            string ngay = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lb_date.Text = ngay;
        }
        private double totalPrice()
        {
            double total = 0;
            foreach (ListViewItem item in listView_cart.Items)
            {
                total += double.Parse(item.SubItems[6].Text);
            }
            return total;
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

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (listView_cart.Items.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống");
                return;
            }
            string maKH = null ;
            string sdt = txt_customer.Text;
            KhachHang kh = _customerService.GetCustomerByPhone(sdt);
            if (kh != null)
            {
                maKH = kh.maKH;
            }
            string maPT = comboBox_method.SelectedValue.ToString();
            string maNV = user.maNV;
            double tongTien = totalPrice();
            string ghichu = "mua tại cửa hàng";
            string ngay = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string maDH = _orderService.GenerateOrderCode();
            DonHang dh = new DonHang();
            dh.maDH = maDH;
            dh.maKH = maKH;
            dh.ngayLapDH = DateTime.Parse(ngay);
            dh.tongTien = decimal.Parse(tongTien.ToString());
            dh.ngayThanhToan = DateTime.Parse(ngay);
            dh.maPT = maPT;
            dh.maNV = maNV;
            dh.ghiChu = ghichu;
            dh.maTT = "TTDH002";
            if (!_orderService.InsertOrder(dh))
            {
                MessageBox.Show("Thanh toán thất bại");
                return;
            }
            foreach (ListViewItem item in listView_cart.Items)
            {
                string tensp = item.SubItems[0].Text;
                int sl = int.Parse(item.SubItems[1].Text);
                string size = item.SubItems[2].Text;
                string da = item.SubItems[3].Text;
                string duong = item.SubItems[4].Text;
                string tra = item.SubItems[5].Text;
                string maSP = _productService.GetProductByName(tensp).maSP;
                ChiTietSanPham CTSP = _productDetailService.GetProductDetailByIdAndSizeId(maSP, size);
                string maCTSP = CTSP.maCTSP;
                string donGia = CTSP.donGia.ToString();
                ChiTietDonHang ctdh = new ChiTietDonHang();
                ctdh.maDH = maDH;
                ctdh.maCTSP = maCTSP;
                ctdh.soLuongDatHang = sl;
                ctdh.donGia = decimal.Parse(donGia);
                string thanhTien = (sl * double.Parse(donGia)).ToString();
                ctdh.thanhTien = decimal.Parse(thanhTien);
                ctdh.lieuLuongDa = da;
                ctdh.lieuLuongNgot = duong;
                ctdh.lieuLuongTra = tra;
                if (!_orderDetailService.InsertOrderDetail(ctdh))
                {
                    MessageBox.Show("Thanh toán thất bại");
                    return;
                }
            }
            MessageBox.Show("Thanh toán thành công");
            this.Close();
        }
    }
}
