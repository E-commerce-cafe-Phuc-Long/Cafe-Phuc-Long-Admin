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
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.btn_updateStatus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_StatusOrder = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(397, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // listBox_order
            // 
            this.listBox_order.FormattingEnabled = true;
            this.listBox_order.ItemHeight = 23;
            this.listBox_order.Location = new System.Drawing.Point(6, 77);
            this.listBox_order.Name = "listBox_order";
            this.listBox_order.Size = new System.Drawing.Size(221, 487);
            this.listBox_order.TabIndex = 4;
            this.listBox_order.SelectedIndexChanged += new System.EventHandler(this.listBox_order_SelectedIndexChanged);
            // 
            // listView_orderDetailsList
            // 
            this.listView_orderDetailsList.HideSelection = false;
            this.listView_orderDetailsList.Location = new System.Drawing.Point(27, 34);
            this.listView_orderDetailsList.Name = "listView_orderDetailsList";
            this.listView_orderDetailsList.Size = new System.Drawing.Size(828, 237);
            this.listView_orderDetailsList.TabIndex = 5;
            this.listView_orderDetailsList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày lập";
            // 
            // dtp_ngayLapHD
            // 
            this.dtp_ngayLapHD.Enabled = false;
            this.dtp_ngayLapHD.Location = new System.Drawing.Point(533, 302);
            this.dtp_ngayLapHD.Name = "dtp_ngayLapHD";
            this.dtp_ngayLapHD.Size = new System.Drawing.Size(322, 30);
            this.dtp_ngayLapHD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(533, 358);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(281, 30);
            this.txt_total.TabIndex = 9;
            // 
            // txt_note
            // 
            this.txt_note.Enabled = false;
            this.txt_note.Location = new System.Drawing.Point(533, 406);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(281, 82);
            this.txt_note.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú";
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.Enabled = false;
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(201, 302);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(200, 31);
            this.comboBox_customer.TabIndex = 11;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.Enabled = false;
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(201, 358);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(200, 31);
            this.comboBox_staff.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(201, 457);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(200, 31);
            this.comboBox_status.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thanh toán";
            // 
            // comboBox_method
            // 
            this.comboBox_method.Enabled = false;
            this.comboBox_method.FormattingEnabled = true;
            this.comboBox_method.Location = new System.Drawing.Point(201, 409);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(200, 31);
            this.comboBox_method.TabIndex = 12;
            // 
            // btn_updateStatus
            // 
            this.btn_updateStatus.BackColor = System.Drawing.Color.Green;
            this.btn_updateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updateStatus.Location = new System.Drawing.Point(94, 508);
            this.btn_updateStatus.Name = "btn_updateStatus";
            this.btn_updateStatus.Size = new System.Drawing.Size(307, 42);
            this.btn_updateStatus.TabIndex = 13;
            this.btn_updateStatus.Text = "Cập nhật trạng thái";
            this.btn_updateStatus.UseVisualStyleBackColor = false;
            this.btn_updateStatus.Click += new System.EventHandler(this.btn_updateStatus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_orderDetailsList);
            this.groupBox1.Controls.Add(this.btn_updateStatus);
            this.groupBox1.Controls.Add(this.txt_note);
            this.groupBox1.Controls.Add(this.comboBox_method);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_staff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_customer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_ngayLapHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 577);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // comboBox_StatusOrder
            // 
            this.comboBox_StatusOrder.FormattingEnabled = true;
            this.comboBox_StatusOrder.Location = new System.Drawing.Point(102, 31);
            this.comboBox_StatusOrder.Name = "comboBox_StatusOrder";
            this.comboBox_StatusOrder.Size = new System.Drawing.Size(125, 31);
            this.comboBox_StatusOrder.TabIndex = 15;
            this.comboBox_StatusOrder.SelectedIndexChanged += new System.EventHandler(this.comboBox_StatusOrder_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.listBox_order);
            this.groupBox2.Controls.Add(this.comboBox_StatusOrder);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 577);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Trạng thái";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmOrderManagement";
            this.Text = "frmOrderManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_method;
        private System.Windows.Forms.Button btn_updateStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_StatusOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
    }
}