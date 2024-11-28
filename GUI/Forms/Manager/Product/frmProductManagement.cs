using BLL.Services;
using BLL.Services.Category;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Size;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Forms.Manager
{
    public partial class frmProductManagement : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductDetailService _productDetailService;
        private readonly ISizeService _sizeService;
        private readonly IRecipeService _recipeService;
        private string _url;
        public frmProductManagement(
            IProductService productService,
            ICategoryService categoryService,
            IProductDetailService productDetailService,
            ISizeService sizeService,
            IRecipeService recipeService
            )
        {
            this._categoryService = categoryService;
            this._productService = productService;
            this._productDetailService = productDetailService;
            this._sizeService = sizeService;
            this._recipeService = recipeService;
            InitializeComponent();
            this.Load += FrmProductManagement_Load;
        }

        private void FrmProductManagement_Load(object sender, EventArgs e)
        {

            listView_ProductList_Config();
            LoadProductsToListView();
            listView_CategoriesList_Config();
            LoadCategoriesToListView();
            listView_ProductDetailList_Config();
            listView_SizeList_Config();
            LoadSizeToListView();
            LoadDataToComboBoxUnit();
            LoadCategoriesToComboBox();
            LoadRecipesToComboBox();
            LoadSizesToComboBox();
        }



        #region Định nghĩa các hàm sử dụng

        private void listView_ProductList_Config()
        {
            listView_ProductList.View = View.Details;
            listView_ProductList.FullRowSelect = true;
            listView_ProductList.GridLines = true;
            listView_ProductList.MultiSelect = false;
            listView_ProductList.Items.Clear();
            listView_ProductList.Columns.Add("Mã sản phẩm", 100);
            listView_ProductList.Columns.Add("Tên sản phẩm", 200);
            listView_ProductList.Columns.Add("Hình ảnh", 200);
            listView_ProductList.Columns.Add("Đơn vị tính", 100);
            listView_ProductList.Columns.Add("Mô tả", 350);
        }
        private void LoadProductsToListView()
        {
            listView_ProductList.Items.Clear();
            var products = _productService.GetProductList();

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.maSP);
                item.SubItems.Add(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                item.Tag = product;

                listView_ProductList.Items.Add(item);
            }

        }
        private void listView_CategoriesList_Config()
        {
            listView_CategoryList.View = View.Details;
            listView_CategoryList.FullRowSelect = true;
            listView_CategoryList.GridLines = true;
            listView_CategoryList.MultiSelect = false;
            listView_CategoryList.Items.Clear();

            listView_CategoryList.Columns.Add("Mã danh mục", 100);
            listView_CategoryList.Columns.Add("Tên danh mục", 200);
            listView_CategoryList.Columns.Add("Mô tả", 350);
        }
        private void LoadCategoriesToListView()
        {
            listView_CategoryList.Items.Clear();
            var categories = _categoryService.GetCategoriesList();

            foreach (var category in categories)
            {
                ListViewItem item = new ListViewItem(category.maDM);
                item.SubItems.Add(category.tenDM);
                item.SubItems.Add(category.moTa);
                listView_CategoryList.Items.Add(item);
            }
        }
        private void LoadProductsByCategoryId(string categoryId)
        {
            listView_ProductList.Items.Clear();
            var products = _productService.GetProductByCategoryId(categoryId);

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.maSP);
                item.SubItems.Add(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                item.Tag = product; 

                listView_ProductList.Items.Add(item);
            }
        }



        #endregion

        private void listView_CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_CategoryList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_CategoryList.SelectedItems[0];
                string categoryName = selectedItem.SubItems[1].Text;

                string categoryId = selectedItem.Text;

                if (categoryId == "")
                {
                    txt_nameCategory.Text = "";

                    LoadProductsToListView();
                }
                else
                {
                    txt_nameCategory.Text = categoryName;
                    LoadProductsByCategoryId(categoryId);
                }
            }

        }
        private void listView_ProductDetailList_Config()
        {
            listView_productDetailList.View = View.Details;
            listView_productDetailList.FullRowSelect = true;
            listView_productDetailList.GridLines = true;
            listView_productDetailList.MultiSelect = false;
            listView_productDetailList.Items.Clear();
            listView_productDetailList.Columns.Add("Size", 100);
            listView_productDetailList.Columns.Add("Đơn giá", 200);
        }
        private void LoadProductDetailToListView()
        {
            listView_productDetailList.Items.Clear();
            var productDetails = _productDetailService.GetProductDetailList();

            foreach (var productDetail in productDetails)
            {
                ListViewItem item = new ListViewItem(productDetail.maSize);
                item.SubItems.Add(productDetail.donGia.ToString());
                item.Tag = productDetail;
                listView_productDetailList.Items.Add(item);
            }
        }
        private void LoadProductDetailsByProductId(string ProductId)
        {
            listView_productDetailList.Items.Clear();
            var productDetails = _productDetailService.GetProductDetailsByProductId(ProductId);

            foreach (var productDetail in productDetails)
            {
                ListViewItem item = new ListViewItem(productDetail.maSize);

                item.SubItems.Add(productDetail.donGia.ToString());
                item.Tag = productDetail;
                listView_productDetailList.Items.Add(item);
            }
        }

        private void listView_ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_ProductList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_ProductList.SelectedItems[0];
                var product = (SanPham)selectedItem.Tag;
                string productId = selectedItem.Text;

                if (productId == "")
                {
                    LoadProductDetailToListView();
                }
                else
                {
                    string productName = selectedItem.SubItems[1].Text;
                    string productImage = selectedItem.SubItems[2].Text;
                    string productUnit = selectedItem.SubItems[3].Text;
                    string productDescription = selectedItem.SubItems[4].Text;
                    txt_nameProduct.Text = productName;
                    txt_imageProduct.Text = productImage;
                    txt_descriptionProduct.Text = productDescription;
                    checkBox_newProduct.Checked = product.spMoi == true;
                    checkBox_bestSeller.Checked = product.spNoiBat == true;
                    SelectInComboBox(product.maDM, product.maCT, productUnit);
                    LoadProductDetailsByProductId(productId);
                }
            }
        }
        private void SelectInComboBox(string maDM,string maCT,string dvt)
        {
            foreach (var item in comboBox_Categories.Items)
            {
                var category = item as DanhMuc;
                if (category != null && category.maDM == maDM)
                {
                    comboBox_Categories.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboBox_recipe.Items)
            {
                var recipe = item as CongThuc;
                if (recipe != null && recipe.maCT == maCT)
                {
                    comboBox_recipe.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboBox_unit.Items)
            {
                string unit = item.ToString();
                if (unit != null && unit == dvt)
                {
                    comboBox_unit.SelectedItem = item;
                    break;
                }
            }
        }
        private void listView_SizeList_Config()
        {
            listView_sizeList.View = View.Details;
            listView_sizeList.FullRowSelect = true;
            listView_sizeList.GridLines = true;
            listView_sizeList.MultiSelect = false;
            listView_sizeList.Items.Clear();
            listView_sizeList.Columns.Add("Mã size", 100);
            listView_sizeList.Columns.Add("Tên Size", 100);
            listView_sizeList.Columns.Add("ghi chú", 200);
        }
        private void LoadSizeToListView()
        {
            listView_sizeList.Items.Clear();
            var sizes = _sizeService.GetSizeList();

            foreach (var size in sizes)
            {
                ListViewItem item = new ListViewItem(size.maSize);
                item.SubItems.Add(size.tenSize);
                item.SubItems.Add(size.ghiChu);
                listView_sizeList.Items.Add(item);
            }
        }

        private void listView_sizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_sizeList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_sizeList.SelectedItems[0];
                string sizeId = selectedItem.Text;

                if (sizeId == "")
                {
                    LoadSizeToListView();
                }
                else
                {
                    string sizeName = selectedItem.SubItems[1].Text;
                    string sizeNote = selectedItem.SubItems[2].Text;
                    txt_nameSize.Text = sizeName;
                    txt_noteSize.Text = sizeNote;

                }
            }
        }
        private void LoadDataToComboBoxUnit()
        {
            string[] units = { "Túi", "Gói", "Hộp", "Ly" };

            comboBox_unit.Items.Clear();
            comboBox_unit.Items.AddRange(units);
        }
        private void LoadCategoriesToComboBox()
        {
            var categories = _categoryService.GetCategoriesList();

            comboBox_Categories.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_Categories.DataSource = categories;
            comboBox_Categories.DisplayMember = "tenDM";
            comboBox_Categories.ValueMember = "maDM";
        }
        private void LoadSizesToComboBox()
        {
            var sizes = _sizeService.GetSizeList();

            comboBox_size.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_size.DataSource = sizes;
            comboBox_size.DisplayMember = "tenSize";
            comboBox_size.ValueMember = "maSize";
        }
        private void LoadRecipesToComboBox()
        {
            var recipes = _recipeService.GetRecipeList();

            comboBox_recipe.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_recipe.DataSource = recipes;
            comboBox_recipe.DisplayMember = "tenCT";
            comboBox_recipe.ValueMember = "maCT";
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txt_nameCategory.Text;
            string categoryDescription = txt_descriptionCategory.Text;
            if (categoryName == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
                return;
            }
            string maDM = _categoryService.GenerateCategoryCode();
            DanhMuc category = new DanhMuc
            {
                maDM = maDM,
                tenDM = categoryName,
                moTa = categoryDescription
            };
            if(_categoryService.InsertCategory(category))
            {
                LoadCategoriesToListView();
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
        }

        private void btn_EditCategory_Click(object sender, EventArgs e)
        {
            if (listView_CategoryList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }
            string maDM = listView_CategoryList.SelectedItems[0].Text;
            string categoryName = txt_nameCategory.Text;
            string categoryDescription = txt_descriptionCategory.Text;
            if (maDM == "")
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa");
                return;
            }
            if (categoryName == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
                return;
            }
            DanhMuc category = new DanhMuc
            {
                maDM = maDM,
                tenDM = categoryName,
                moTa = categoryDescription
            };
            if (_categoryService.UpdateCategory(category))
            {
                LoadCategoriesToListView();
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục thất bại");
            }
        }

        private void btn_searchCategory_Click(object sender, EventArgs e)
        {
            string keyword = txt_searchCategory.Text;
            listView_CategoryList.Items.Clear();
            List<DanhMuc> categories = _categoryService.SearchCategory(keyword);

            foreach (DanhMuc category in categories)
            {
                ListViewItem item = new ListViewItem(category.maDM);
                item.SubItems.Add(category.tenDM);
                item.SubItems.Add(category.moTa);
                listView_CategoryList.Items.Add(item);
            }
           
        }

        private void btn_showAllCategories_Click(object sender, EventArgs e)
        {
            LoadCategoriesToListView();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string imageUrl = _productService.UploadImage(imagePath);
                this._url = imageUrl;
                string[] pathSegments = imageUrl.Split('/');
                string lastSegment = pathSegments[pathSegments.Length - 1];
                txt_imageProduct.Text = "upload thành công";

            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            string productName = txt_nameProduct.Text;
            string productImage = this._url;
            
            string productUnit = comboBox_unit.Text;
            string productDescription = txt_descriptionProduct.Text;
            string categoryId = comboBox_Categories.SelectedValue.ToString();
            string recipeId = comboBox_recipe.SelectedValue.ToString();
            bool newProduct = checkBox_newProduct.Checked;
            bool bestSeller = checkBox_bestSeller.Checked;

            if (productName == "" || productImage =="" || productUnit =="" || productDescription=="")
            {
                MessageBox.Show("Vui lòng nhập các thông tin cần thiết");
                return;
            }
            SanPham product = new SanPham
            {
                maSP = _productService.GenerateProductCode(),
                tenSP = productName,
                hinhAnh = productImage,
                donViTinh = productUnit,
                moTa = productDescription,
                maDM = categoryId,
                maCT = recipeId,
                maTT = "TT001",
                spMoi = newProduct,
                spNoiBat = bestSeller
            };
            if (_productService.InsertProduct(product))
            {
                LoadProductsToListView();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            if(listView_ProductList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }
            string productId = listView_ProductList.SelectedItems[0].Text;
            string productName = txt_nameProduct.Text;
            string productImage = txt_imageProduct.Text;
            string productUnit = comboBox_unit.Text;
            string productDescription = txt_descriptionProduct.Text;
            string categoryId = comboBox_Categories.SelectedValue.ToString();
            string recipeId = comboBox_recipe.SelectedValue.ToString();
            bool newProduct = checkBox_newProduct.Checked;
            bool bestSeller = checkBox_bestSeller.Checked;

            if (productName == "" || productImage == "" || productUnit == "" || productDescription == "")
            {
                MessageBox.Show("Vui lòng nhập các thông tin cần thiết");
                return;
            }

            SanPham product = new SanPham
            {
                maSP = productId,
                tenSP = productName,
                hinhAnh = productImage,
                donViTinh = productUnit,
                moTa = productDescription,
                maDM = categoryId,
                maCT = recipeId,
                spMoi = newProduct,
                spNoiBat = bestSeller
            };
            if (_productService.UpdateProduct(product))
            {
                LoadProductsToListView();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại");
            }
        }

        private void btn_deteleProduct_Click(object sender, EventArgs e)
        {
            if (listView_ProductList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xoá");
                return;
            }
            string productId = listView_ProductList.SelectedItems[0].Text;
            if (_productService.DeleteProduct(productId))
            {
                LoadProductsToListView();
            }
            else
            {
                MessageBox.Show("Xoá sản phẩm thất bại");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadProductsToListView();
        }

        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
           
            string keyword = txt_searchProduct.Text;
            listView_ProductList.Items.Clear();
            List<SanPham> products = _productService.SearchProduct(keyword);
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.maSP);
                item.SubItems.Add(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                item.Tag = product;

                listView_ProductList.Items.Add(item);
            }
        }

        private void btn_addSize_Click(object sender, EventArgs e)
        {
            string sizeName = txt_nameSize.Text;
            string sizeNote = txt_noteSize.Text;
            if (sizeName == "")
            {
                MessageBox.Show("Vui lòng nhập tên size");
                return;
            }
            string maSize = _sizeService.GenerateSizeCode();
            DTO.Size size = new DTO.Size
            {
                maSize = maSize,
                tenSize = sizeName,
                ghiChu = sizeNote
            };
            if (_sizeService.InsertSize(size))
            {
                LoadSizeToListView();
            }
            else
            {
                MessageBox.Show("Thêm size thất bại");
            }

        }

        private void btn_editSize_Click(object sender, EventArgs e)
        {
            if (listView_sizeList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn size cần sửa");
                return;
            }
            string sizeId = listView_sizeList.SelectedItems[0].Text;
            string sizeName = txt_nameSize.Text;
            string sizeNote = txt_noteSize.Text;
            if (sizeName == "")
            {
                MessageBox.Show("Vui lòng nhập tên size");
                return;
            }
            DTO.Size size = new DTO.Size
            {
                maSize = sizeId,
                tenSize = sizeName,
                ghiChu = sizeNote
            };
            if (_sizeService.UpdateSize(size))
            {
                LoadSizeToListView();
            }
            else
            {
                MessageBox.Show("Cập nhật size thất bại");
            }

        }

        private void btn_deleteSize_Click(object sender, EventArgs e)
        {
            if (listView_sizeList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn size cần xoá");
                return;
            }
            string sizeId = listView_sizeList.SelectedItems[0].Text;
            if (_sizeService.DeleteSize(sizeId))
            {
                LoadSizeToListView();
            }
            else
            {
                MessageBox.Show("Xoá size thất bại");
            }

        }

        private void btn_searchSize_Click(object sender, EventArgs e)
        {

            string keyword = txt_searchSize.Text;
            listView_sizeList.Items.Clear();
            List<DTO.Size> sizes = _sizeService.SearchSize(keyword);
            foreach (var size in sizes)
            {
                ListViewItem item = new ListViewItem(size.maSize);
                item.SubItems.Add(size.tenSize);
                item.SubItems.Add(size.ghiChu);
                listView_sizeList.Items.Add(item);
            }
        }

        private void btn_showAllSize_Click(object sender, EventArgs e)
        {
            LoadSizeToListView();
        }

        private void listView_productDetailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_productDetailList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_productDetailList.SelectedItems[0];
                var chitiet = (ChiTietSanPham)selectedItem.Tag;
                

                string maChiTiet = selectedItem.Text;

                if (maChiTiet != "")
                {
                    string price = chitiet.donGia.ToString();
                    textBox_price.Text = price;
                    foreach (var item in comboBox_size.Items)
                    {
                        var size = item as DTO.Size;
                        if (size != null && size.maSize == chitiet.maSize)
                        {
                            comboBox_size.SelectedItem = item;
                            break;
                        }
                    }

                }
            }
        }

        private void btn_addProductDetail_Click(object sender, EventArgs e)
        {
            if (listView_ProductList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm chi tiết");
                return;
            }
            string productId = listView_ProductList.SelectedItems[0].Text;
            string sizeId = comboBox_size.SelectedValue.ToString();
            string price = textBox_price.Text;
            if (productId == "" || sizeId == "" || price == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            ChiTietSanPham chitietsanpham = _productDetailService.GetProductDetailByIdAndSizeId(productId, sizeId);
            if(chitietsanpham != null)
            {
                MessageBox.Show("Sản phẩm đã có chi tiết với size này");
                return;
            }
         
            ChiTietSanPham productDetail = new ChiTietSanPham
            {
                maCTSP = _productDetailService.GenerateProductDetailCode(),
                maSP = productId,
                maSize = sizeId,
                donGia = int.Parse(price)
            };
            if (_productDetailService.InsertProductDetail(productDetail))
            {
                LoadProductDetailsByProductId(productId);
            }
            else
            {
                MessageBox.Show("Thêm chi tiết sản phẩm thất bại");
            }

        }

        private void btn_editProductDetail_Click(object sender, EventArgs e)
        {

            if (listView_productDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết sản phẩm cần sửa");
                return;
            }
            string sizeId = comboBox_size.SelectedValue.ToString();
            string price = textBox_price.Text;
           
            if (  sizeId == "" || price == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (listView_productDetailList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_productDetailList.SelectedItems[0];
                var chitiet = (ChiTietSanPham)selectedItem.Tag;
                ChiTietSanPham chitietsanpham = _productDetailService.GetProductDetailByIdAndSizeId(chitiet.maSP, sizeId);
                if (chitietsanpham != null)
                {
                    MessageBox.Show("Sản phẩm đã có chi tiết với size này");
                    return;
                }
                ChiTietSanPham productDetail = new ChiTietSanPham
                {
                    maSP = chitiet.maSP,
                    maSize = sizeId,
                    donGia = int.Parse(price)
                };
                if (_productDetailService.UpdateProductDetail(productDetail))
                {
                    LoadProductDetailsByProductId(chitiet.maSP);
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết sản phẩm thất bại");
                }
            }
        }

        private void btn_deleteProductDetail_Click(object sender, EventArgs e)
        {

            if (listView_productDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết sản phẩm cần xoá");
                return;
            }
            if (listView_productDetailList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_productDetailList.SelectedItems[0];
                var chitiet = (ChiTietSanPham)selectedItem.Tag;
                if (_productDetailService.DeleteProductDetail(chitiet.maCTSP))
                {
                    LoadProductDetailsByProductId(chitiet.maSP);
                }
                else
                {
                    MessageBox.Show("Xoá chi tiết sản phẩm thất bại");
                }
            }
        }
    }
}
