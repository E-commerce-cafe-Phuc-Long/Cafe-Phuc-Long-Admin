namespace GUI.Forms.Manager
{
    partial class frmProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Title = new System.Windows.Forms.Label();
            this.listView_CategoryList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descriptionCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nameCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_showAllCategories = new System.Windows.Forms.Button();
            this.btn_searchCategory = new System.Windows.Forms.Button();
            this.txt_searchCategory = new System.Windows.Forms.TextBox();
            this.btn_EditCategory = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.listView_ProductList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_deleteProductDetail = new System.Windows.Forms.Button();
            this.btn_editProductDetail = new System.Windows.Forms.Button();
            this.btn_addProductDetail = new System.Windows.Forms.Button();
            this.listView_productDetailList = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_recipe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_newProduct = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_bestSeller = new System.Windows.Forms.CheckBox();
            this.txt_descriptionProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_imageProduct = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_deteleProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_searchProduct = new System.Windows.Forms.Button();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_nameSize = new System.Windows.Forms.TextBox();
            this.txt_noteSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_showAllSize = new System.Windows.Forms.Button();
            this.btn_searchSize = new System.Windows.Forms.Button();
            this.txt_searchSize = new System.Windows.Forms.TextBox();
            this.btn_deleteSize = new System.Windows.Forms.Button();
            this.btn_editSize = new System.Windows.Forms.Button();
            this.btn_addSize = new System.Windows.Forms.Button();
            this.listView_sizeList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(602, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(297, 45);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Quản Lý Sản Phẩm";
            // 
            // listView_CategoryList
            // 
            this.listView_CategoryList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_CategoryList.HideSelection = false;
            this.listView_CategoryList.Location = new System.Drawing.Point(6, 66);
            this.listView_CategoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_CategoryList.Name = "listView_CategoryList";
            this.listView_CategoryList.Size = new System.Drawing.Size(315, 422);
            this.listView_CategoryList.TabIndex = 3;
            this.listView_CategoryList.UseCompatibleStateImageBehavior = false;
            this.listView_CategoryList.SelectedIndexChanged += new System.EventHandler(this.listView_CategoryList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_descriptionCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nameCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_showAllCategories);
            this.groupBox1.Controls.Add(this.btn_searchCategory);
            this.groupBox1.Controls.Add(this.txt_searchCategory);
            this.groupBox1.Controls.Add(this.btn_EditCategory);
            this.groupBox1.Controls.Add(this.btn_addCategory);
            this.groupBox1.Controls.Add(this.listView_CategoryList);
            this.groupBox1.Location = new System.Drawing.Point(11, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(328, 695);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // txt_descriptionCategory
            // 
            this.txt_descriptionCategory.Location = new System.Drawing.Point(136, 552);
            this.txt_descriptionCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_descriptionCategory.Multiline = true;
            this.txt_descriptionCategory.Name = "txt_descriptionCategory";
            this.txt_descriptionCategory.Size = new System.Drawing.Size(184, 82);
            this.txt_descriptionCategory.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mô tả";
            // 
            // txt_nameCategory
            // 
            this.txt_nameCategory.Location = new System.Drawing.Point(136, 515);
            this.txt_nameCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nameCategory.Name = "txt_nameCategory";
            this.txt_nameCategory.Size = new System.Drawing.Size(184, 27);
            this.txt_nameCategory.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên danh mục";
            // 
            // btn_showAllCategories
            // 
            this.btn_showAllCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAllCategories.Location = new System.Drawing.Point(246, 29);
            this.btn_showAllCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showAllCategories.Name = "btn_showAllCategories";
            this.btn_showAllCategories.Size = new System.Drawing.Size(74, 32);
            this.btn_showAllCategories.TabIndex = 9;
            this.btn_showAllCategories.Text = "Tất cả";
            this.btn_showAllCategories.UseVisualStyleBackColor = true;
            this.btn_showAllCategories.Click += new System.EventHandler(this.btn_showAllCategories_Click);
            // 
            // btn_searchCategory
            // 
            this.btn_searchCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCategory.Location = new System.Drawing.Point(158, 29);
            this.btn_searchCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_searchCategory.Name = "btn_searchCategory";
            this.btn_searchCategory.Size = new System.Drawing.Size(82, 32);
            this.btn_searchCategory.TabIndex = 8;
            this.btn_searchCategory.Text = "Tìm kiếm";
            this.btn_searchCategory.UseVisualStyleBackColor = true;
            this.btn_searchCategory.Click += new System.EventHandler(this.btn_searchCategory_Click);
            // 
            // txt_searchCategory
            // 
            this.txt_searchCategory.Location = new System.Drawing.Point(5, 31);
            this.txt_searchCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_searchCategory.Name = "txt_searchCategory";
            this.txt_searchCategory.Size = new System.Drawing.Size(146, 27);
            this.txt_searchCategory.TabIndex = 7;
            // 
            // btn_EditCategory
            // 
            this.btn_EditCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCategory.Location = new System.Drawing.Point(201, 645);
            this.btn_EditCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_EditCategory.Name = "btn_EditCategory";
            this.btn_EditCategory.Size = new System.Drawing.Size(119, 31);
            this.btn_EditCategory.TabIndex = 5;
            this.btn_EditCategory.Text = "Sửa ";
            this.btn_EditCategory.UseVisualStyleBackColor = true;
            this.btn_EditCategory.Click += new System.EventHandler(this.btn_EditCategory_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategory.Location = new System.Drawing.Point(93, 645);
            this.btn_addCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(103, 31);
            this.btn_addCategory.TabIndex = 4;
            this.btn_addCategory.Text = "Thêm";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // listView_ProductList
            // 
            this.listView_ProductList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ProductList.HideSelection = false;
            this.listView_ProductList.Location = new System.Drawing.Point(9, 64);
            this.listView_ProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_ProductList.Name = "listView_ProductList";
            this.listView_ProductList.Size = new System.Drawing.Size(700, 284);
            this.listView_ProductList.TabIndex = 3;
            this.listView_ProductList.UseCompatibleStateImageBehavior = false;
            this.listView_ProductList.SelectedIndexChanged += new System.EventHandler(this.listView_ProductList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_size);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_price);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_deleteProductDetail);
            this.groupBox2.Controls.Add(this.btn_editProductDetail);
            this.groupBox2.Controls.Add(this.btn_addProductDetail);
            this.groupBox2.Controls.Add(this.listView_productDetailList);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1074, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(383, 325);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(99, 191);
            this.comboBox_size.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(257, 31);
            this.comboBox_size.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Size";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(99, 235);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(257, 30);
            this.textBox_price.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đơn giá";
            // 
            // btn_deleteProductDetail
            // 
            this.btn_deleteProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProductDetail.Location = new System.Drawing.Point(257, 279);
            this.btn_deleteProductDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deleteProductDetail.Name = "btn_deleteProductDetail";
            this.btn_deleteProductDetail.Size = new System.Drawing.Size(99, 33);
            this.btn_deleteProductDetail.TabIndex = 6;
            this.btn_deleteProductDetail.Text = "Xoá";
            this.btn_deleteProductDetail.UseVisualStyleBackColor = true;
            this.btn_deleteProductDetail.Click += new System.EventHandler(this.btn_deleteProductDetail_Click);
            // 
            // btn_editProductDetail
            // 
            this.btn_editProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProductDetail.Location = new System.Drawing.Point(150, 279);
            this.btn_editProductDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editProductDetail.Name = "btn_editProductDetail";
            this.btn_editProductDetail.Size = new System.Drawing.Size(101, 33);
            this.btn_editProductDetail.TabIndex = 5;
            this.btn_editProductDetail.Text = "Sửa ";
            this.btn_editProductDetail.UseVisualStyleBackColor = true;
            this.btn_editProductDetail.Click += new System.EventHandler(this.btn_editProductDetail_Click);
            // 
            // btn_addProductDetail
            // 
            this.btn_addProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProductDetail.Location = new System.Drawing.Point(45, 279);
            this.btn_addProductDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addProductDetail.Name = "btn_addProductDetail";
            this.btn_addProductDetail.Size = new System.Drawing.Size(101, 33);
            this.btn_addProductDetail.TabIndex = 4;
            this.btn_addProductDetail.Text = "Thêm";
            this.btn_addProductDetail.UseVisualStyleBackColor = true;
            this.btn_addProductDetail.Click += new System.EventHandler(this.btn_addProductDetail_Click);
            // 
            // listView_productDetailList
            // 
            this.listView_productDetailList.HideSelection = false;
            this.listView_productDetailList.Location = new System.Drawing.Point(5, 27);
            this.listView_productDetailList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_productDetailList.Name = "listView_productDetailList";
            this.listView_productDetailList.Size = new System.Drawing.Size(372, 131);
            this.listView_productDetailList.TabIndex = 3;
            this.listView_productDetailList.UseCompatibleStateImageBehavior = false;
            this.listView_productDetailList.SelectedIndexChanged += new System.EventHandler(this.listView_productDetailList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_Categories);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBox_recipe);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.txt_descriptionProduct);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox_unit);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_imageProduct);
            this.groupBox3.Controls.Add(this.btn_Upload);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_nameProduct);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_deteleProduct);
            this.groupBox3.Controls.Add(this.btn_editProduct);
            this.groupBox3.Controls.Add(this.btn_addProduct);
            this.groupBox3.Controls.Add(this.btn_searchProduct);
            this.groupBox3.Controls.Add(this.txt_searchProduct);
            this.groupBox3.Controls.Add(this.listView_ProductList);
            this.groupBox3.Location = new System.Drawing.Point(345, 49);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(724, 707);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(480, 374);
            this.comboBox_Categories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(218, 28);
            this.comboBox_Categories.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Danh mục";
            // 
            // comboBox_recipe
            // 
            this.comboBox_recipe.FormattingEnabled = true;
            this.comboBox_recipe.Location = new System.Drawing.Point(480, 447);
            this.comboBox_recipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_recipe.Name = "comboBox_recipe";
            this.comboBox_recipe.Size = new System.Drawing.Size(218, 28);
            this.comboBox_recipe.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Công thức";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.checkBox_newProduct);
            this.panel2.Location = new System.Drawing.Point(480, 535);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 44);
            this.panel2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sản phẩm mới";
            // 
            // checkBox_newProduct
            // 
            this.checkBox_newProduct.AutoSize = true;
            this.checkBox_newProduct.Location = new System.Drawing.Point(175, 16);
            this.checkBox_newProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_newProduct.Name = "checkBox_newProduct";
            this.checkBox_newProduct.Size = new System.Drawing.Size(18, 17);
            this.checkBox_newProduct.TabIndex = 26;
            this.checkBox_newProduct.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkBox_bestSeller);
            this.panel1.Location = new System.Drawing.Point(480, 483);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 44);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sản phẩm nổi bật";
            // 
            // checkBox_bestSeller
            // 
            this.checkBox_bestSeller.AutoSize = true;
            this.checkBox_bestSeller.Location = new System.Drawing.Point(175, 15);
            this.checkBox_bestSeller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_bestSeller.Name = "checkBox_bestSeller";
            this.checkBox_bestSeller.Size = new System.Drawing.Size(18, 17);
            this.checkBox_bestSeller.TabIndex = 26;
            this.checkBox_bestSeller.UseVisualStyleBackColor = true;
            // 
            // txt_descriptionProduct
            // 
            this.txt_descriptionProduct.Location = new System.Drawing.Point(119, 482);
            this.txt_descriptionProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_descriptionProduct.Multiline = true;
            this.txt_descriptionProduct.Name = "txt_descriptionProduct";
            this.txt_descriptionProduct.Size = new System.Drawing.Size(229, 77);
            this.txt_descriptionProduct.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mô tả";
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.Location = new System.Drawing.Point(119, 446);
            this.comboBox_unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.Size = new System.Drawing.Size(229, 28);
            this.comboBox_unit.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Đơn vị tính";
            // 
            // txt_imageProduct
            // 
            this.txt_imageProduct.AutoSize = true;
            this.txt_imageProduct.Location = new System.Drawing.Point(244, 413);
            this.txt_imageProduct.Name = "txt_imageProduct";
            this.txt_imageProduct.Size = new System.Drawing.Size(0, 20);
            this.txt_imageProduct.TabIndex = 20;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(119, 407);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(115, 31);
            this.btn_Upload.TabIndex = 19;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hình ảnh";
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Location = new System.Drawing.Point(119, 371);
            this.txt_nameProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.Size = new System.Drawing.Size(229, 27);
            this.txt_nameProduct.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên sản phẩm";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(605, 26);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 31);
            this.button5.TabIndex = 14;
            this.button5.Text = "Tất cả";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_deteleProduct
            // 
            this.btn_deteleProduct.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deteleProduct.Location = new System.Drawing.Point(268, 581);
            this.btn_deteleProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deteleProduct.Name = "btn_deteleProduct";
            this.btn_deteleProduct.Size = new System.Drawing.Size(103, 31);
            this.btn_deteleProduct.TabIndex = 13;
            this.btn_deteleProduct.Text = "Xoá";
            this.btn_deteleProduct.UseVisualStyleBackColor = true;
            this.btn_deteleProduct.Click += new System.EventHandler(this.btn_deteleProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProduct.Location = new System.Drawing.Point(138, 581);
            this.btn_editProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(113, 31);
            this.btn_editProduct.TabIndex = 12;
            this.btn_editProduct.Text = "Sửa ";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.Location = new System.Drawing.Point(17, 581);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(97, 31);
            this.btn_addProduct.TabIndex = 11;
            this.btn_addProduct.Text = "Thêm";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_searchProduct
            // 
            this.btn_searchProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchProduct.Location = new System.Drawing.Point(265, 24);
            this.btn_searchProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_searchProduct.Name = "btn_searchProduct";
            this.btn_searchProduct.Size = new System.Drawing.Size(103, 32);
            this.btn_searchProduct.TabIndex = 10;
            this.btn_searchProduct.Text = "Tìm kiếm";
            this.btn_searchProduct.UseVisualStyleBackColor = true;
            this.btn_searchProduct.Click += new System.EventHandler(this.btn_searchProduct_Click);
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Location = new System.Drawing.Point(10, 28);
            this.txt_searchProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(250, 27);
            this.txt_searchProduct.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_nameSize);
            this.groupBox4.Controls.Add(this.txt_noteSize);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btn_showAllSize);
            this.groupBox4.Controls.Add(this.btn_searchSize);
            this.groupBox4.Controls.Add(this.txt_searchSize);
            this.groupBox4.Controls.Add(this.btn_deleteSize);
            this.groupBox4.Controls.Add(this.btn_editSize);
            this.groupBox4.Controls.Add(this.btn_addSize);
            this.groupBox4.Controls.Add(this.listView_sizeList);
            this.groupBox4.Location = new System.Drawing.Point(1075, 382);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(382, 374);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Size";
            // 
            // txt_nameSize
            // 
            this.txt_nameSize.Location = new System.Drawing.Point(104, 182);
            this.txt_nameSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nameSize.Name = "txt_nameSize";
            this.txt_nameSize.Size = new System.Drawing.Size(252, 27);
            this.txt_nameSize.TabIndex = 33;
            // 
            // txt_noteSize
            // 
            this.txt_noteSize.Location = new System.Drawing.Point(104, 224);
            this.txt_noteSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_noteSize.Multiline = true;
            this.txt_noteSize.Name = "txt_noteSize";
            this.txt_noteSize.Size = new System.Drawing.Size(252, 89);
            this.txt_noteSize.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tên size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Ghi chú";
            // 
            // btn_showAllSize
            // 
            this.btn_showAllSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAllSize.Location = new System.Drawing.Point(310, 24);
            this.btn_showAllSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showAllSize.Name = "btn_showAllSize";
            this.btn_showAllSize.Size = new System.Drawing.Size(65, 34);
            this.btn_showAllSize.TabIndex = 15;
            this.btn_showAllSize.Text = "Tất cả";
            this.btn_showAllSize.UseVisualStyleBackColor = true;
            this.btn_showAllSize.Click += new System.EventHandler(this.btn_showAllSize_Click);
            // 
            // btn_searchSize
            // 
            this.btn_searchSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchSize.Location = new System.Drawing.Point(207, 24);
            this.btn_searchSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_searchSize.Name = "btn_searchSize";
            this.btn_searchSize.Size = new System.Drawing.Size(81, 32);
            this.btn_searchSize.TabIndex = 8;
            this.btn_searchSize.Text = "Tìm kiếm";
            this.btn_searchSize.UseVisualStyleBackColor = true;
            this.btn_searchSize.Click += new System.EventHandler(this.btn_searchSize_Click);
            // 
            // txt_searchSize
            // 
            this.txt_searchSize.Location = new System.Drawing.Point(5, 27);
            this.txt_searchSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_searchSize.Name = "txt_searchSize";
            this.txt_searchSize.Size = new System.Drawing.Size(196, 27);
            this.txt_searchSize.TabIndex = 7;
            // 
            // btn_deleteSize
            // 
            this.btn_deleteSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteSize.Location = new System.Drawing.Point(257, 324);
            this.btn_deleteSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deleteSize.Name = "btn_deleteSize";
            this.btn_deleteSize.Size = new System.Drawing.Size(99, 31);
            this.btn_deleteSize.TabIndex = 6;
            this.btn_deleteSize.Text = "Xoá";
            this.btn_deleteSize.UseVisualStyleBackColor = true;
            this.btn_deleteSize.Click += new System.EventHandler(this.btn_deleteSize_Click);
            // 
            // btn_editSize
            // 
            this.btn_editSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editSize.Location = new System.Drawing.Point(155, 324);
            this.btn_editSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editSize.Name = "btn_editSize";
            this.btn_editSize.Size = new System.Drawing.Size(97, 31);
            this.btn_editSize.TabIndex = 5;
            this.btn_editSize.Text = "Sửa ";
            this.btn_editSize.UseVisualStyleBackColor = true;
            this.btn_editSize.Click += new System.EventHandler(this.btn_editSize_Click);
            // 
            // btn_addSize
            // 
            this.btn_addSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSize.Location = new System.Drawing.Point(58, 324);
            this.btn_addSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addSize.Name = "btn_addSize";
            this.btn_addSize.Size = new System.Drawing.Size(91, 31);
            this.btn_addSize.TabIndex = 4;
            this.btn_addSize.Text = "Thêm";
            this.btn_addSize.UseVisualStyleBackColor = true;
            this.btn_addSize.Click += new System.EventHandler(this.btn_addSize_Click);
            // 
            // listView_sizeList
            // 
            this.listView_sizeList.HideSelection = false;
            this.listView_sizeList.Location = new System.Drawing.Point(5, 59);
            this.listView_sizeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_sizeList.Name = "listView_sizeList";
            this.listView_sizeList.Size = new System.Drawing.Size(370, 113);
            this.listView_sizeList.TabIndex = 3;
            this.listView_sizeList.UseCompatibleStateImageBehavior = false;
            this.listView_sizeList.SelectedIndexChanged += new System.EventHandler(this.listView_sizeList_SelectedIndexChanged);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1470, 776);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductManagement";
            this.Text = "Quản Lý Sản Phẩm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.ListView listView_CategoryList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_EditCategory;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_searchCategory;
        private System.Windows.Forms.TextBox txt_searchCategory;
        private System.Windows.Forms.ListView listView_ProductList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_deleteProductDetail;
        private System.Windows.Forms.Button btn_editProductDetail;
        private System.Windows.Forms.Button btn_addProductDetail;
        private System.Windows.Forms.ListView listView_productDetailList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_deteleProduct;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_searchProduct;
        private System.Windows.Forms.TextBox txt_searchProduct;
        private System.Windows.Forms.Button btn_showAllCategories;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_nameCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_imageProduct;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_bestSeller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descriptionProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_newProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_recipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_noteSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_showAllSize;
        private System.Windows.Forms.Button btn_searchSize;
        private System.Windows.Forms.TextBox txt_searchSize;
        private System.Windows.Forms.Button btn_deleteSize;
        private System.Windows.Forms.Button btn_editSize;
        private System.Windows.Forms.Button btn_addSize;
        private System.Windows.Forms.ListView listView_sizeList;
        private System.Windows.Forms.TextBox txt_nameSize;
        private System.Windows.Forms.TextBox txt_descriptionCategory;
        private System.Windows.Forms.Label label4;
    }
}