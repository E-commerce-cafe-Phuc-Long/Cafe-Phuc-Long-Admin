namespace GUI.Forms
{
    partial class frmCheckout
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
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_cart = new System.Windows.Forms.ListView();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_totalPrice = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lb_customer = new System.Windows.Forms.Label();
            this.lb_cus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // txt_customer
            // 
            this.txt_customer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.Location = new System.Drawing.Point(584, 134);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(224, 30);
            this.txt_customer.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(825, 130);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 36);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(724, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng giá";
            // 
            // listView_cart
            // 
            this.listView_cart.HideSelection = false;
            this.listView_cart.Location = new System.Drawing.Point(12, 84);
            this.listView_cart.Name = "listView_cart";
            this.listView_cart.Size = new System.Drawing.Size(389, 326);
            this.listView_cart.TabIndex = 4;
            this.listView_cart.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_method
            // 
            this.comboBox_method.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_method.FormattingEnabled = true;
            this.comboBox_method.Location = new System.Drawing.Point(725, 81);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(190, 31);
            this.comboBox_method.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phương thức";
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPrice.ForeColor = System.Drawing.Color.Red;
            this.lb_totalPrice.Location = new System.Drawing.Point(833, 315);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(82, 23);
            this.lb_totalPrice.TabIndex = 0;
            this.lb_totalPrice.Text = "100,000";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Location = new System.Drawing.Point(584, 356);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(342, 51);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "Thanh toán";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customer.Location = new System.Drawing.Point(580, 188);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(118, 23);
            this.lb_customer.TabIndex = 7;
            this.lb_customer.Text = "Khách hàng:";
            // 
            // lb_cus
            // 
            this.lb_cus.AutoSize = true;
            this.lb_cus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cus.Location = new System.Drawing.Point(724, 188);
            this.lb_cus.Name = "lb_cus";
            this.lb_cus.Size = new System.Drawing.Size(123, 23);
            this.lb_cus.TabIndex = 8;
            this.lb_cus.Text = "Cao nhật linh";
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.lb_cus);
            this.Controls.Add(this.lb_customer);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.listView_cart);
            this.Controls.Add(this.comboBox_method);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_totalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_cart;
        private System.Windows.Forms.ComboBox comboBox_method;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_totalPrice;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label lb_cus;
    }
}