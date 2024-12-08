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
            this.dgv_Detail = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_tongSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Detail
            // 
            this.dgv_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detail.Location = new System.Drawing.Point(12, 245);
            this.dgv_Detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Detail.Name = "dgv_Detail";
            this.dgv_Detail.RowHeadersWidth = 51;
            this.dgv_Detail.RowTemplate.Height = 24;
            this.dgv_Detail.Size = new System.Drawing.Size(866, 332);
            this.dgv_Detail.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(252, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "Chi Tiết Phiếu Nhập Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tổng tiền:";
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(182, 71);
            this.txt_tongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(309, 30);
            this.txt_tongTien.TabIndex = 47;
            // 
            // txt_tongSoLuong
            // 
            this.txt_tongSoLuong.Location = new System.Drawing.Point(182, 109);
            this.txt_tongSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tongSoLuong.Name = "txt_tongSoLuong";
            this.txt_tongSoLuong.Size = new System.Drawing.Size(309, 30);
            this.txt_tongSoLuong.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tổng số lượng: ";
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(182, 31);
            this.txt_maPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(309, 30);
            this.txt_maPhieuNhap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_tongSoLuong);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox4.Controls.Add(this.txt_tongTien);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(185, 65);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(515, 159);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // frmGoodsReceiptDetailsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Detail);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoodsReceiptDetailsManagement";
            this.Text = "Chi Tiết Phiếu Nhập Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_tongSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}