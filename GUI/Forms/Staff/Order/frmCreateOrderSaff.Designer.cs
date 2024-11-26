namespace GUI.Forms
{
    partial class frmCreateOrderSaff
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
            this.panel_category = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView_cart = new System.Windows.Forms.ListView();
            this.groupBox_product = new System.Windows.Forms.GroupBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_tongTien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_deleteCart = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_category
            // 
            this.panel_category.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_category.Location = new System.Drawing.Point(0, 130);
            this.panel_category.Name = "panel_category";
            this.panel_category.Size = new System.Drawing.Size(359, 589);
            this.panel_category.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(821, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "TẠO ĐƠN HÀNG";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView_cart);
            this.panel3.Location = new System.Drawing.Point(1311, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 589);
            this.panel3.TabIndex = 4;
            // 
            // listView_cart
            // 
            this.listView_cart.HideSelection = false;
            this.listView_cart.Location = new System.Drawing.Point(4, 3);
            this.listView_cart.Name = "listView_cart";
            this.listView_cart.Size = new System.Drawing.Size(462, 528);
            this.listView_cart.TabIndex = 0;
            this.listView_cart.UseCompatibleStateImageBehavior = false;
            this.listView_cart.SelectedIndexChanged += new System.EventHandler(this.listView_cart_SelectedIndexChanged);
            // 
            // groupBox_product
            // 
            this.groupBox_product.Location = new System.Drawing.Point(365, 133);
            this.groupBox_product.Name = "groupBox_product";
            this.groupBox_product.Size = new System.Drawing.Size(940, 579);
            this.groupBox_product.TabIndex = 5;
            this.groupBox_product.TabStop = false;
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_checkout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_checkout.Location = new System.Drawing.Point(1315, 7);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(236, 63);
            this.btn_checkout.TabIndex = 6;
            this.btn_checkout.Text = "Trang thanh toán";
            this.btn_checkout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1557, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng tiền:";
            // 
            // label_tongTien
            // 
            this.label_tongTien.AutoSize = true;
            this.label_tongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_tongTien.ForeColor = System.Drawing.Color.Red;
            this.label_tongTien.Location = new System.Drawing.Point(1660, 27);
            this.label_tongTien.Name = "label_tongTien";
            this.label_tongTien.Size = new System.Drawing.Size(20, 23);
            this.label_tongTien.TabIndex = 8;
            this.label_tongTien.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btn_checkout);
            this.panel2.Controls.Add(this.label_tongTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 718);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1784, 100);
            this.panel2.TabIndex = 9;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(345, 92);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(264, 27);
            this.txt_search.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(615, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 35);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_deleteCart
            // 
            this.btn_deleteCart.Location = new System.Drawing.Point(1647, 88);
            this.btn_deleteCart.Name = "btn_deleteCart";
            this.btn_deleteCart.Size = new System.Drawing.Size(130, 35);
            this.btn_deleteCart.TabIndex = 12;
            this.btn_deleteCart.Text = "Làm mới";
            this.btn_deleteCart.UseVisualStyleBackColor = true;
            this.btn_deleteCart.Click += new System.EventHandler(this.btn_deleteCart_Click);
            // 
            // frmCreateOrderSaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1784, 818);
            this.Controls.Add(this.btn_deleteCart);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox_product);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_category);
            this.Name = "frmCreateOrderSaff";
            this.Text = "frmOrderSaff";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox_product;
        private System.Windows.Forms.ListView listView_cart;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_tongTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_deleteCart;
    }
}