namespace GUI.Forms
{
    partial class frmOrderManagement
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
            this.listBox_order = new System.Windows.Forms.ListBox();
            this.listView_orderDetailsList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ngayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(348, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // listBox_order
            // 
            this.listBox_order.FormattingEnabled = true;
            this.listBox_order.ItemHeight = 16;
            this.listBox_order.Location = new System.Drawing.Point(12, 82);
            this.listBox_order.Name = "listBox_order";
            this.listBox_order.Size = new System.Drawing.Size(243, 484);
            this.listBox_order.TabIndex = 4;
            this.listBox_order.SelectedIndexChanged += new System.EventHandler(this.listBox_order_SelectedIndexChanged);
            // 
            // listView_orderDetailsList
            // 
            this.listView_orderDetailsList.HideSelection = false;
            this.listView_orderDetailsList.Location = new System.Drawing.Point(300, 82);
            this.listView_orderDetailsList.Name = "listView_orderDetailsList";
            this.listView_orderDetailsList.Size = new System.Drawing.Size(751, 224);
            this.listView_orderDetailsList.TabIndex = 5;
            this.listView_orderDetailsList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày lập";
            // 
            // dtp_ngayLapHD
            // 
            this.dtp_ngayLapHD.Location = new System.Drawing.Point(762, 342);
            this.dtp_ngayLapHD.Name = "dtp_ngayLapHD";
            this.dtp_ngayLapHD.Size = new System.Drawing.Size(200, 22);
            this.dtp_ngayLapHD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(762, 400);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(201, 22);
            this.txt_total.TabIndex = 9;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(762, 453);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(201, 70);
            this.txt_note.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú";
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(430, 344);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(200, 24);
            this.comboBox_customer.TabIndex = 11;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(430, 400);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(200, 24);
            this.comboBox_staff.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(430, 499);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thanh toán";
            // 
            // comboBox_method
            // 
            this.comboBox_method.FormattingEnabled = true;
            this.comboBox_method.Location = new System.Drawing.Point(430, 451);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(200, 24);
            this.comboBox_method.TabIndex = 12;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 592);
            this.Controls.Add(this.comboBox_method);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox_staff);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_ngayLapHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_orderDetailsList);
            this.Controls.Add(this.listBox_order);
            this.Controls.Add(this.label1);
            this.Name = "frmOrderManagement";
            this.Text = "frmOrderManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_order;
        private System.Windows.Forms.ListView listView_orderDetailsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ngayLapHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.ComboBox comboBox_staff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_method;
    }
}