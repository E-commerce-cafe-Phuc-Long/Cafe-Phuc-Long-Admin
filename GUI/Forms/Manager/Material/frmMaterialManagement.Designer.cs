namespace GUI.Forms.Manager
{
    partial class frmMaterialManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_showAllCT = new System.Windows.Forms.Button();
            this.btn_searchCT = new System.Windows.Forms.Button();
            this.txt_searchCT = new System.Windows.Forms.TextBox();
            this.btn_deleteRecipe = new System.Windows.Forms.Button();
            this.btn_editRecipe = new System.Windows.Forms.Button();
            this.btn_addRecipe = new System.Windows.Forms.Button();
            this.txt_descRecipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_recipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_recipeList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_showAllNL = new System.Windows.Forms.Button();
            this.btn_searchNL = new System.Windows.Forms.Button();
            this.comboBox_DVT = new System.Windows.Forms.ComboBox();
            this.txt_searchNL = new System.Windows.Forms.TextBox();
            this.nud_soLuongMaterial = new System.Windows.Forms.NumericUpDown();
            this.btn_editMaterial = new System.Windows.Forms.Button();
            this.btn_deleteMaterial = new System.Windows.Forms.Button();
            this.btn_addMaterial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_materialName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_materialsList = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nud_soLuongR_M = new System.Windows.Forms.NumericUpDown();
            this.comboBox_material = new System.Windows.Forms.ComboBox();
            this.comboBox_recipe = new System.Windows.Forms.ComboBox();
            this.btn_editM_R = new System.Windows.Forms.Button();
            this.btn_deleteM_R = new System.Windows.Forms.Button();
            this.btn_addM_R = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView_recipe_materialsList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuongMaterial)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuongR_M)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nguyên Liệu - Công Thức";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_showAllCT);
            this.groupBox1.Controls.Add(this.btn_searchCT);
            this.groupBox1.Controls.Add(this.txt_searchCT);
            this.groupBox1.Controls.Add(this.btn_deleteRecipe);
            this.groupBox1.Controls.Add(this.btn_editRecipe);
            this.groupBox1.Controls.Add(this.btn_addRecipe);
            this.groupBox1.Controls.Add(this.txt_descRecipe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_recipeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView_recipeList);
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(658, 668);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công thức";
            // 
            // btn_showAllCT
            // 
            this.btn_showAllCT.Location = new System.Drawing.Point(545, 27);
            this.btn_showAllCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showAllCT.Name = "btn_showAllCT";
            this.btn_showAllCT.Size = new System.Drawing.Size(101, 29);
            this.btn_showAllCT.TabIndex = 6;
            this.btn_showAllCT.Text = "Tất cả";
            this.btn_showAllCT.UseVisualStyleBackColor = true;
            this.btn_showAllCT.Click += new System.EventHandler(this.btn_showAllCT_Click);
            // 
            // btn_searchCT
            // 
            this.btn_searchCT.Location = new System.Drawing.Point(264, 27);
            this.btn_searchCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_searchCT.Name = "btn_searchCT";
            this.btn_searchCT.Size = new System.Drawing.Size(101, 29);
            this.btn_searchCT.TabIndex = 5;
            this.btn_searchCT.Text = "Tìm";
            this.btn_searchCT.UseVisualStyleBackColor = true;
            this.btn_searchCT.Click += new System.EventHandler(this.btn_searchCT_Click);
            // 
            // txt_searchCT
            // 
            this.txt_searchCT.Location = new System.Drawing.Point(22, 28);
            this.txt_searchCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_searchCT.Name = "txt_searchCT";
            this.txt_searchCT.Size = new System.Drawing.Size(236, 27);
            this.txt_searchCT.TabIndex = 4;
            // 
            // btn_deleteRecipe
            // 
            this.btn_deleteRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRecipe.Location = new System.Drawing.Point(352, 617);
            this.btn_deleteRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deleteRecipe.Name = "btn_deleteRecipe";
            this.btn_deleteRecipe.Size = new System.Drawing.Size(106, 39);
            this.btn_deleteRecipe.TabIndex = 3;
            this.btn_deleteRecipe.Text = "Xoá";
            this.btn_deleteRecipe.UseVisualStyleBackColor = true;
            this.btn_deleteRecipe.Click += new System.EventHandler(this.btn_deleteRecipe_Click);
            // 
            // btn_editRecipe
            // 
            this.btn_editRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRecipe.Location = new System.Drawing.Point(242, 617);
            this.btn_editRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editRecipe.Name = "btn_editRecipe";
            this.btn_editRecipe.Size = new System.Drawing.Size(105, 39);
            this.btn_editRecipe.TabIndex = 3;
            this.btn_editRecipe.Text = "Sửa";
            this.btn_editRecipe.UseVisualStyleBackColor = true;
            this.btn_editRecipe.Click += new System.EventHandler(this.btn_editRecipe_Click);
            // 
            // btn_addRecipe
            // 
            this.btn_addRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRecipe.Location = new System.Drawing.Point(140, 617);
            this.btn_addRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addRecipe.Name = "btn_addRecipe";
            this.btn_addRecipe.Size = new System.Drawing.Size(96, 39);
            this.btn_addRecipe.TabIndex = 3;
            this.btn_addRecipe.Text = "Thêm";
            this.btn_addRecipe.UseVisualStyleBackColor = true;
            this.btn_addRecipe.Click += new System.EventHandler(this.btn_addRecipe_Click);
            // 
            // txt_descRecipe
            // 
            this.txt_descRecipe.Location = new System.Drawing.Point(139, 515);
            this.txt_descRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_descRecipe.Multiline = true;
            this.txt_descRecipe.Name = "txt_descRecipe";
            this.txt_descRecipe.Size = new System.Drawing.Size(319, 86);
            this.txt_descRecipe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mô tả";
            // 
            // txt_recipeName
            // 
            this.txt_recipeName.Location = new System.Drawing.Point(139, 480);
            this.txt_recipeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_recipeName.Name = "txt_recipeName";
            this.txt_recipeName.Size = new System.Drawing.Size(319, 27);
            this.txt_recipeName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên công thức";
            // 
            // listView_recipeList
            // 
            this.listView_recipeList.HideSelection = false;
            this.listView_recipeList.Location = new System.Drawing.Point(12, 64);
            this.listView_recipeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_recipeList.Name = "listView_recipeList";
            this.listView_recipeList.Size = new System.Drawing.Size(634, 408);
            this.listView_recipeList.TabIndex = 0;
            this.listView_recipeList.UseCompatibleStateImageBehavior = false;
            this.listView_recipeList.SelectedIndexChanged += new System.EventHandler(this.listView_recipeList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_showAllNL);
            this.groupBox2.Controls.Add(this.btn_searchNL);
            this.groupBox2.Controls.Add(this.comboBox_DVT);
            this.groupBox2.Controls.Add(this.txt_searchNL);
            this.groupBox2.Controls.Add(this.nud_soLuongMaterial);
            this.groupBox2.Controls.Add(this.btn_editMaterial);
            this.groupBox2.Controls.Add(this.btn_deleteMaterial);
            this.groupBox2.Controls.Add(this.btn_addMaterial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_materialName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listView_materialsList);
            this.groupBox2.Location = new System.Drawing.Point(687, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(557, 428);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nguyên liệu";
            // 
            // btn_showAllNL
            // 
            this.btn_showAllNL.Location = new System.Drawing.Point(440, 26);
            this.btn_showAllNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showAllNL.Name = "btn_showAllNL";
            this.btn_showAllNL.Size = new System.Drawing.Size(101, 29);
            this.btn_showAllNL.TabIndex = 6;
            this.btn_showAllNL.Text = "Tất cả";
            this.btn_showAllNL.UseVisualStyleBackColor = true;
            this.btn_showAllNL.Click += new System.EventHandler(this.btn_showAllNL_Click);
            // 
            // btn_searchNL
            // 
            this.btn_searchNL.Location = new System.Drawing.Point(209, 27);
            this.btn_searchNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_searchNL.Name = "btn_searchNL";
            this.btn_searchNL.Size = new System.Drawing.Size(101, 29);
            this.btn_searchNL.TabIndex = 5;
            this.btn_searchNL.Text = "Tìm";
            this.btn_searchNL.UseVisualStyleBackColor = true;
            this.btn_searchNL.Click += new System.EventHandler(this.btn_searchNL_Click);
            // 
            // comboBox_DVT
            // 
            this.comboBox_DVT.FormattingEnabled = true;
            this.comboBox_DVT.Items.AddRange(new object[] {
            "gram",
            "hôp",
            "quả",
            "lít"});
            this.comboBox_DVT.Location = new System.Drawing.Point(180, 337);
            this.comboBox_DVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_DVT.Name = "comboBox_DVT";
            this.comboBox_DVT.Size = new System.Drawing.Size(248, 28);
            this.comboBox_DVT.TabIndex = 6;
            // 
            // txt_searchNL
            // 
            this.txt_searchNL.Location = new System.Drawing.Point(12, 28);
            this.txt_searchNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_searchNL.Name = "txt_searchNL";
            this.txt_searchNL.Size = new System.Drawing.Size(191, 27);
            this.txt_searchNL.TabIndex = 4;
            // 
            // nud_soLuongMaterial
            // 
            this.nud_soLuongMaterial.Location = new System.Drawing.Point(323, 302);
            this.nud_soLuongMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud_soLuongMaterial.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_soLuongMaterial.Name = "nud_soLuongMaterial";
            this.nud_soLuongMaterial.Size = new System.Drawing.Size(105, 27);
            this.nud_soLuongMaterial.TabIndex = 4;
            this.nud_soLuongMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_editMaterial
            // 
            this.btn_editMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editMaterial.Location = new System.Drawing.Point(208, 372);
            this.btn_editMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editMaterial.Name = "btn_editMaterial";
            this.btn_editMaterial.Size = new System.Drawing.Size(102, 36);
            this.btn_editMaterial.TabIndex = 3;
            this.btn_editMaterial.Text = "Sửa";
            this.btn_editMaterial.UseVisualStyleBackColor = true;
            this.btn_editMaterial.Click += new System.EventHandler(this.btn_editMaterial_Click);
            // 
            // btn_deleteMaterial
            // 
            this.btn_deleteMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteMaterial.Location = new System.Drawing.Point(326, 372);
            this.btn_deleteMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deleteMaterial.Name = "btn_deleteMaterial";
            this.btn_deleteMaterial.Size = new System.Drawing.Size(102, 36);
            this.btn_deleteMaterial.TabIndex = 3;
            this.btn_deleteMaterial.Text = "Xoá";
            this.btn_deleteMaterial.UseVisualStyleBackColor = true;
            this.btn_deleteMaterial.Click += new System.EventHandler(this.btn_deleteMaterial_Click);
            // 
            // btn_addMaterial
            // 
            this.btn_addMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMaterial.Location = new System.Drawing.Point(88, 372);
            this.btn_addMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addMaterial.Name = "btn_addMaterial";
            this.btn_addMaterial.Size = new System.Drawing.Size(102, 36);
            this.btn_addMaterial.TabIndex = 3;
            this.btn_addMaterial.Text = "Thêm";
            this.btn_addMaterial.UseVisualStyleBackColor = true;
            this.btn_addMaterial.Click += new System.EventHandler(this.btn_addMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng";
            // 
            // txt_materialName
            // 
            this.txt_materialName.Location = new System.Drawing.Point(180, 269);
            this.txt_materialName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_materialName.Name = "txt_materialName";
            this.txt_materialName.Size = new System.Drawing.Size(248, 27);
            this.txt_materialName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên nguyên liệu";
            // 
            // listView_materialsList
            // 
            this.listView_materialsList.HideSelection = false;
            this.listView_materialsList.Location = new System.Drawing.Point(12, 63);
            this.listView_materialsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_materialsList.Name = "listView_materialsList";
            this.listView_materialsList.Size = new System.Drawing.Size(529, 201);
            this.listView_materialsList.TabIndex = 0;
            this.listView_materialsList.UseCompatibleStateImageBehavior = false;
            this.listView_materialsList.SelectedIndexChanged += new System.EventHandler(this.listView_materialsList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nud_soLuongR_M);
            this.groupBox3.Controls.Add(this.comboBox_material);
            this.groupBox3.Controls.Add(this.comboBox_recipe);
            this.groupBox3.Controls.Add(this.btn_editM_R);
            this.groupBox3.Controls.Add(this.btn_deleteM_R);
            this.groupBox3.Controls.Add(this.btn_addM_R);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.listView_recipe_materialsList);
            this.groupBox3.Location = new System.Drawing.Point(687, 72);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(557, 238);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // nud_soLuongR_M
            // 
            this.nud_soLuongR_M.Location = new System.Drawing.Point(421, 166);
            this.nud_soLuongR_M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud_soLuongR_M.Name = "nud_soLuongR_M";
            this.nud_soLuongR_M.Size = new System.Drawing.Size(124, 27);
            this.nud_soLuongR_M.TabIndex = 6;
            this.nud_soLuongR_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_material
            // 
            this.comboBox_material.FormattingEnabled = true;
            this.comboBox_material.Location = new System.Drawing.Point(118, 202);
            this.comboBox_material.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_material.Name = "comboBox_material";
            this.comboBox_material.Size = new System.Drawing.Size(186, 28);
            this.comboBox_material.TabIndex = 5;
            // 
            // comboBox_recipe
            // 
            this.comboBox_recipe.FormattingEnabled = true;
            this.comboBox_recipe.Location = new System.Drawing.Point(118, 166);
            this.comboBox_recipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_recipe.Name = "comboBox_recipe";
            this.comboBox_recipe.Size = new System.Drawing.Size(186, 28);
            this.comboBox_recipe.TabIndex = 4;
            // 
            // btn_editM_R
            // 
            this.btn_editM_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editM_R.Location = new System.Drawing.Point(445, 67);
            this.btn_editM_R.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editM_R.Name = "btn_editM_R";
            this.btn_editM_R.Size = new System.Drawing.Size(90, 32);
            this.btn_editM_R.TabIndex = 3;
            this.btn_editM_R.Text = "Sửa";
            this.btn_editM_R.UseVisualStyleBackColor = true;
            this.btn_editM_R.Click += new System.EventHandler(this.btn_editM_R_Click);
            // 
            // btn_deleteM_R
            // 
            this.btn_deleteM_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteM_R.Location = new System.Drawing.Point(445, 107);
            this.btn_deleteM_R.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_deleteM_R.Name = "btn_deleteM_R";
            this.btn_deleteM_R.Size = new System.Drawing.Size(90, 32);
            this.btn_deleteM_R.TabIndex = 3;
            this.btn_deleteM_R.Text = "Xoá";
            this.btn_deleteM_R.UseVisualStyleBackColor = true;
            this.btn_deleteM_R.Click += new System.EventHandler(this.btn_deleteM_R_Click);
            // 
            // btn_addM_R
            // 
            this.btn_addM_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addM_R.Location = new System.Drawing.Point(445, 27);
            this.btn_addM_R.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addM_R.Name = "btn_addM_R";
            this.btn_addM_R.Size = new System.Drawing.Size(90, 32);
            this.btn_addM_R.TabIndex = 3;
            this.btn_addM_R.Text = "Thêm";
            this.btn_addM_R.UseVisualStyleBackColor = true;
            this.btn_addM_R.Click += new System.EventHandler(this.btn_addM_R_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nguyên liệu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Công thức";
            // 
            // listView_recipe_materialsList
            // 
            this.listView_recipe_materialsList.HideSelection = false;
            this.listView_recipe_materialsList.Location = new System.Drawing.Point(6, 18);
            this.listView_recipe_materialsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_recipe_materialsList.Name = "listView_recipe_materialsList";
            this.listView_recipe_materialsList.Size = new System.Drawing.Size(413, 130);
            this.listView_recipe_materialsList.TabIndex = 0;
            this.listView_recipe_materialsList.UseCompatibleStateImageBehavior = false;
            this.listView_recipe_materialsList.SelectedIndexChanged += new System.EventHandler(this.listView_recipe_materialsList_SelectedIndexChanged);
            // 
            // frmMaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1270, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMaterialManagement";
            this.Text = "Quản Lý Nguyên Liệu - Công Thức";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuongMaterial)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuongR_M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_recipeList;
        private System.Windows.Forms.Button btn_deleteRecipe;
        private System.Windows.Forms.Button btn_editRecipe;
        private System.Windows.Forms.Button btn_addRecipe;
        private System.Windows.Forms.TextBox txt_descRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_recipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_soLuongMaterial;
        private System.Windows.Forms.Button btn_editMaterial;
        private System.Windows.Forms.Button btn_deleteMaterial;
        private System.Windows.Forms.Button btn_addMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_materialName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView_materialsList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_editM_R;
        private System.Windows.Forms.Button btn_deleteM_R;
        private System.Windows.Forms.Button btn_addM_R;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView_recipe_materialsList;
        private System.Windows.Forms.NumericUpDown nud_soLuongR_M;
        private System.Windows.Forms.ComboBox comboBox_material;
        private System.Windows.Forms.ComboBox comboBox_recipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_DVT;
        private System.Windows.Forms.Button btn_showAllCT;
        private System.Windows.Forms.Button btn_searchCT;
        private System.Windows.Forms.TextBox txt_searchCT;
        private System.Windows.Forms.Button btn_showAllNL;
        private System.Windows.Forms.Button btn_searchNL;
        private System.Windows.Forms.TextBox txt_searchNL;
    }
}