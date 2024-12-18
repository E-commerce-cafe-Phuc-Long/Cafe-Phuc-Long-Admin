﻿namespace GUI.Forms.Manager.GoodsReceipt
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
            this.dgvGoodsReceipt = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(321, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Phiếu Nhập";
            // 
            // dgvGoodsReceipt
            // 
            this.dgvGoodsReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsReceipt.Location = new System.Drawing.Point(12, 186);
            this.dgvGoodsReceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGoodsReceipt.Name = "dgvGoodsReceipt";
            this.dgvGoodsReceipt.RowHeadersWidth = 51;
            this.dgvGoodsReceipt.RowTemplate.Height = 24;
            this.dgvGoodsReceipt.Size = new System.Drawing.Size(898, 367);
            this.dgvGoodsReceipt.TabIndex = 3;
            this.dgvGoodsReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsReceipt_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(502, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(198, 29);
            this.txt_maPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maPhieuNhap.Multiline = true;
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(274, 26);
            this.txt_maPhieuNhap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.btn_Detail);
            this.groupBox1.Location = new System.Drawing.Point(541, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(369, 82);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(189, 32);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(162, 33);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Tạo phiếu nhập";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.Location = new System.Drawing.Point(28, 32);
            this.btn_Detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(145, 33);
            this.btn_Detail.TabIndex = 0;
            this.btn_Detail.Text = "Xem chi tiết";
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // frmGoodsReceiptManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvGoodsReceipt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoodsReceiptManagement";
            this.Text = "Quản Lý Phiếu Nhập";
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
        private System.Windows.Forms.DataGridView dgvGoodsReceipt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Insert;
    }
}