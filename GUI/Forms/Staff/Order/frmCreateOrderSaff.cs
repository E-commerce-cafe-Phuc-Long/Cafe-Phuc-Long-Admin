using BLL.Services;
using BLL.Services.Category;
using BLL.Services.Dosage;
using BLL.Services.ProductDetail;
using BLL.Services.Size;
using DTO;
using GUI.Forms.Staff;
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
    public partial class frmCreateOrderSaff : Form
    {
        public string sl { get; set; }

        public string da { get; set; }
        public string duong { get; set; }
        public string tra { get; set; }
        public bool confirm { get; set; }

        public string size { get; set; }


        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;

        private readonly IDosageService _dosageService;
        private readonly ISizeService _sizeService;

        public frmCreateOrderSaff(ICategoryService categoryService, IProductService productService, IDosageService dosageService, ISizeService sizeService, IProductDetailService productDetailService)
        {
            this._categoryService = categoryService;
            this._productService = productService;
            this._dosageService = dosageService;
            this._sizeService = sizeService;
            this._productDetailService = productDetailService;
            InitializeComponent();
            this.Load += FrmOrderSaff_Load;
            _sizeService = sizeService;
        }

        private void FrmOrderSaff_Load(object sender, EventArgs e)
        {
            loadButtonCategoriesList();
            listView_ProductList_Config();

        }
       
        private void loadButtonCategoriesList()
        {
            // Lấy danh sách các loại sản phẩm
            List<DanhMuc> categories = _categoryService.GetCategoriesList();
            int buttonHeight = 68;
            int spacing = 10;
            int i = 0;
            
            Button btn_all = new Button()
            {
                Width = panel_category.Width - 30,
                Height = buttonHeight,
                Text = "Tất cả",
                Location = new Point(10, i * (buttonHeight + spacing)),
                BackColor = Color.LightBlue,
            };
            btn_all.Click += Btnall_Click;
            panel_category.Controls.Add(btn_all);
            foreach (DanhMuc category in categories)
            {
                i++;
                Button btn = new Button()
                {
                    Width = panel_category.Width - 30,
                    Height = buttonHeight,
                    Text = category.tenDM,
                    Location = new Point(10, i * (buttonHeight + spacing)),
                    BackColor = Color.LightBlue,
                    Tag = category
                };

                btn.Click += Btn_Click;
                panel_category.Controls.Add(btn);
                if (panel_category is FlowLayoutPanel flowLayoutPanel)
                {
                    flowLayoutPanel.SetFlowBreak(btn, true);
                }
            }
            panel_category.AutoScroll = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Tag is DanhMuc category)
            {
                // Lấy maDM từ đối tượng DanhMuc
                string maDM = category.maDM;
                
                LoadProductsByCategory(maDM);
            }
        }
        private void LoadProductsByCategory(string maDM)
        {
            // Gọi dịch vụ hoặc logic lấy danh sách sản phẩm theo maDM
            List<SanPham> products = _productService.GetProductByCategoryId(maDM);

            loadProductList(products);
        }
        private void RegisterClickEventForControls(Control control, EventHandler eventHandler)
        {
            control.Click += eventHandler;

            foreach (Control child in control.Controls)
            {
                RegisterClickEventForControls(child, eventHandler);
            }
        }

        private void loadProductList(List<SanPham> products)
        {
            groupBox_product.Controls.Clear();
            int sl = products.Count();
            int panelWidth = 120;
            int panelHeight = 180;
            int spacing = 10;
            int maxColumns = groupBox_product.Width / (panelWidth + spacing);
            int currentColumn = 0;
            int currentRow = 0;
            Panel panel = new Panel();
            panel.Width = groupBox_product.Width;
            panel.Height = groupBox_product.Height;
            panel.AutoScroll = true;

            groupBox_product.Controls.Add(panel);
            int i = 0;
             foreach (SanPham product in products)
            {
                i++;

                UC_Product uc_product = new UC_Product(product);
                uc_product.Width = panelWidth;
                uc_product.Height = panelHeight;
                uc_product.Location = new Point(currentColumn * (panelWidth + spacing), currentRow * (panelHeight + spacing));
                
                uc_product.Tag = product;
                RegisterClickEventForControls(uc_product, UC_Product_Click);
                panel.Controls.Add(uc_product);
                currentColumn++;
                if (currentColumn >= maxColumns)
                {
                    currentColumn = 0;
                    currentRow++;
                }
            }
        }
     
        private void Btnall_Click(object sender, EventArgs e)
        {
            List<SanPham> products = _productService.GetProductList();
            loadProductList(products);
        }
        private void listView_ProductList_Config()
        {
            listView_cart.View = View.Details;
            listView_cart.FullRowSelect = true;
            listView_cart.GridLines = true;
            listView_cart.MultiSelect = false;
            listView_cart.Items.Clear();
            listView_cart.Columns.Add("Tên sản phẩm", 200);
            listView_cart.Columns.Add("Số lượng", 100);
            listView_cart.Columns.Add("Size", 100);
            listView_cart.Columns.Add("Đá", 100);
            listView_cart.Columns.Add("Đường", 100);
            listView_cart.Columns.Add("Trà", 100);
            listView_cart.Columns.Add("Giá", 200);
        }
        
        private void UC_Product_Click(object sender, EventArgs e)
        {
            UC_Product clickedProduct = sender as UC_Product;
            confirm = false;
            if (clickedProduct != null && clickedProduct.Tag is SanPham product) {
                frmSelectDrink selectDrinkForm = new frmSelectDrink(_dosageService, _sizeService, product.maSP);
                selectDrinkForm.Owner = this;
                selectDrinkForm.StartPosition = FormStartPosition.CenterParent;
                selectDrinkForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            if(confirm == true)
            {
                
                    // Kiểm tra nếu sản phẩm đã có trong danh sách
                    bool isProductExist = false;
                    foreach (ListViewItem item in listView_cart.Items)
                    {
                        if (item.Text == product.tenSP && item.SubItems[2].Text == size && item.SubItems[3].Text == da && item.SubItems[4].Text == duong && item.SubItems[5].Text == tra)
                        {
                            // Tăng số lượng sản phẩm thêm 1
                            int quantity = int.Parse(item.SubItems[1].Text);
                            item.SubItems[1].Text = (quantity + int.Parse(sl)).ToString();
                            isProductExist = true;
                            break;
                        }
                    }

                    if (!isProductExist)
                    {
                        ListViewItem item = new ListViewItem(product.tenSP);
                        item.SubItems.Add(sl);
                        item.SubItems.Add(size);
                        item.SubItems.Add(da);
                        item.SubItems.Add(duong);
                        item.SubItems.Add(tra);
                        string gia = _productDetailService.GetProductDetailByIdAndSizeId(product.maSP, size).ToString();
                        item.SubItems.Add(gia);
                        item.SubItems.Add(tra);

                        listView_cart.Items.Add(item);
                    }
            }
            
        }

    }

}
