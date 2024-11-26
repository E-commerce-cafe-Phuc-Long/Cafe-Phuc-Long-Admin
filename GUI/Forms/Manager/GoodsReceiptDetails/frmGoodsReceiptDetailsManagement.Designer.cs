namespace GUI.Forms.Manager.GoodsReceiptDetails
{
    partial class frmGoodsReceiptDetailsManagement
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tenNL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.dgv_Detail = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_tongSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_thanhTien);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_donGia);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_soLuong);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox_tenNL);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox4.Location = new System.Drawing.Point(29, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 251);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Location = new System.Drawing.Point(151, 197);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(265, 22);
            this.txt_thanhTien.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Đơn giá : ";
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(151, 153);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(265, 22);
            this.txt_donGia.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Thành tiền :";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(151, 111);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(265, 22);
            this.txt_soLuong.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số lượng : ";
            // 
            // comboBox_tenNL
            // 
            this.comboBox_tenNL.FormattingEnabled = true;
            this.comboBox_tenNL.Location = new System.Drawing.Point(151, 68);
            this.comboBox_tenNL.Name = "comboBox_tenNL";
            this.comboBox_tenNL.Size = new System.Drawing.Size(265, 24);
            this.comboBox_tenNL.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên nguyên liệu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã phiếu nhập :";
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(151, 32);
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(265, 22);
            this.txt_maPhieuNhap.TabIndex = 10;
            this.txt_maPhieuNhap.TextChanged += new System.EventHandler(this.txt_soLuong_TextChanged);
            // 
            // dgv_Detail
            // 
            this.dgv_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detail.Location = new System.Drawing.Point(29, 401);
            this.dgv_Detail.Name = "dgv_Detail";
            this.dgv_Detail.RowHeadersWidth = 51;
            this.dgv_Detail.RowTemplate.Height = 24;
            this.dgv_Detail.Size = new System.Drawing.Size(975, 231);
            this.dgv_Detail.TabIndex = 39;
            this.dgv_Detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detail_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(298, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "Chi tiết phiếu nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tổng tiền :";
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(145, 348);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(265, 22);
            this.txt_tongTien.TabIndex = 47;
            // 
            // txt_tongSoLuong
            // 
            this.txt_tongSoLuong.Location = new System.Drawing.Point(622, 354);
            this.txt_tongSoLuong.Name = "txt_tongSoLuong";
            this.txt_tongSoLuong.Size = new System.Drawing.Size(265, 22);
            this.txt_tongSoLuong.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tổng số lượng : ";
            // 
            // frmGoodsReceiptDetailsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tongSoLuong);
            this.Controls.Add(this.txt_tongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Detail);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmGoodsReceiptDetailsManagement";
            this.Text = "frmGoodsReceiptDetailsManagement";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.DataGridView dgv_Detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tenNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_tongSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.Label label8;
    }
}