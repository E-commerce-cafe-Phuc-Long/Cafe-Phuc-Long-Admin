namespace GUI.Forms.Manager.GoodsReceipt
{
    partial class frmGoodsReceiptManagement
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dgvGoodsReceipt = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.dtp_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceipt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(511, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu nhập";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(459, 297);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(585, 297);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(140, 23);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Hiển thị tất cả";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dgvGoodsReceipt
            // 
            this.dgvGoodsReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsReceipt.Location = new System.Drawing.Point(12, 347);
            this.dgvGoodsReceipt.Name = "dgvGoodsReceipt";
            this.dgvGoodsReceipt.RowHeadersWidth = 51;
            this.dgvGoodsReceipt.RowTemplate.Height = 24;
            this.dgvGoodsReceipt.Size = new System.Drawing.Size(1154, 241);
            this.dgvGoodsReceipt.TabIndex = 3;
            this.dgvGoodsReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsReceipt_CellClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 297);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(441, 22);
            this.txt_Search.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Supplier);
            this.groupBox2.Controls.Add(this.dtp_ngayNhap);
            this.groupBox2.Controls.Add(this.txt_tongTien);
            this.groupBox2.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 181);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(594, 39);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(265, 24);
            this.comboBox_Supplier.TabIndex = 9;
            // 
            // dtp_ngayNhap
            // 
            this.dtp_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayNhap.Location = new System.Drawing.Point(131, 98);
            this.dtp_ngayNhap.Name = "dtp_ngayNhap";
            this.dtp_ngayNhap.Size = new System.Drawing.Size(265, 22);
            this.dtp_ngayNhap.TabIndex = 8;
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(594, 95);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(265, 22);
            this.txt_tongTien.TabIndex = 7;
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(131, 41);
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(265, 22);
            this.txt_maPhieuNhap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhà cung cấp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.btn_Detail);
            this.groupBox1.Location = new System.Drawing.Point(940, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 181);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(36, 95);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(184, 23);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Tạo phiếu nhập";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.Location = new System.Drawing.Point(36, 38);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(184, 23);
            this.btn_Detail.TabIndex = 0;
            this.btn_Detail.Text = "Xem chi tiết";
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // frmGoodsReceiptManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgvGoodsReceipt);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Name = "frmGoodsReceiptManagement";
            this.Text = "frmGoodsReceiptManagement";
            this.Load += new System.EventHandler(this.frmGoodsReceiptManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceipt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgvGoodsReceipt;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtp_ngayNhap;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Insert;
    }
}