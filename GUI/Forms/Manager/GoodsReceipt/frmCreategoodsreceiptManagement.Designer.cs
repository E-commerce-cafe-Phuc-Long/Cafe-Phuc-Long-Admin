namespace GUI.Forms.Manager.GoodsReceipt
{
    partial class frmCreategoodsreceiptManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_tenNL = new System.Windows.Forms.ComboBox();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_taoPhieu = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taoPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tongTien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp_ngayNhap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_Supplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(434, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Enabled = false;
            this.txt_tongTien.Location = new System.Drawing.Point(166, 146);
            this.txt_tongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(249, 30);
            this.txt_tongTien.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tổng tiền:";
            // 
            // dtp_ngayNhap
            // 
            this.dtp_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayNhap.Location = new System.Drawing.Point(166, 108);
            this.dtp_ngayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_ngayNhap.Name = "dtp_ngayNhap";
            this.dtp_ngayNhap.Size = new System.Drawing.Size(249, 30);
            this.dtp_ngayNhap.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày nhập:";
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(166, 69);
            this.comboBox_Supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(249, 31);
            this.comboBox_Supplier.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Enabled = false;
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(166, 31);
            this.txt_maPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(249, 30);
            this.txt_maPhieuNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_tenNL);
            this.groupBox2.Controls.Add(this.txt_thanhTien);
            this.groupBox2.Controls.Add(this.txt_donGia);
            this.groupBox2.Controls.Add(this.txt_soLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(507, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(447, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn nguyên liệu cần nhập";
            // 
            // comboBox_tenNL
            // 
            this.comboBox_tenNL.FormattingEnabled = true;
            this.comboBox_tenNL.Location = new System.Drawing.Point(167, 34);
            this.comboBox_tenNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_tenNL.Name = "comboBox_tenNL";
            this.comboBox_tenNL.Size = new System.Drawing.Size(249, 31);
            this.comboBox_tenNL.TabIndex = 9;
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Enabled = false;
            this.txt_thanhTien.Location = new System.Drawing.Point(167, 149);
            this.txt_thanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(249, 30);
            this.txt_thanhTien.TabIndex = 8;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(167, 111);
            this.txt_donGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(249, 30);
            this.txt_donGia.TabIndex = 7;
            this.txt_donGia.TextChanged += new System.EventHandler(this.txt_donGia_TextChanged);
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(167, 73);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(249, 30);
            this.txt_soLuong.TabIndex = 6;
            this.txt_soLuong.TextChanged += new System.EventHandler(this.txt_soLuong_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nguyên liệu";
            // 
            // dgv_taoPhieu
            // 
            this.dgv_taoPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taoPhieu.Location = new System.Drawing.Point(16, 344);
            this.dgv_taoPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_taoPhieu.Name = "dgv_taoPhieu";
            this.dgv_taoPhieu.RowHeadersWidth = 51;
            this.dgv_taoPhieu.RowTemplate.Height = 24;
            this.dgv_taoPhieu.Size = new System.Drawing.Size(938, 313);
            this.dgv_taoPhieu.TabIndex = 3;
            this.dgv_taoPhieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taoPhieu_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(754, 685);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 37);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(551, 274);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(103, 33);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.Location = new System.Drawing.Point(868, 685);
            this.btn_drop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(86, 37);
            this.btn_drop.TabIndex = 6;
            this.btn_drop.Text = "Hủy";
            this.btn_drop.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(321, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 34);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tạo Phiếu Nhập";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(798, 274);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 33);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(673, 274);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(103, 33);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frmCreategoodsreceiptManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 736);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_drop);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_taoPhieu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCreategoodsreceiptManagement";
            this.Text = "Tạo Phiếu Nhập";
            this.Load += new System.EventHandler(this.frmCreategoodsreceiptManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taoPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.DataGridView dgv_taoPhieu;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.DateTimePicker dtp_ngayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox comboBox_tenNL;
    }
}