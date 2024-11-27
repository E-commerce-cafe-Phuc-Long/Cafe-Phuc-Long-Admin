namespace GUI.Forms
{
    partial class frmSelectDrink
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
            this.comboBox_da = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_duong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tra = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.NumericUpDown();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đá";
            // 
            // comboBox_da
            // 
            this.comboBox_da.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox_da.FormattingEnabled = true;
            this.comboBox_da.Location = new System.Drawing.Point(457, 40);
            this.comboBox_da.Name = "comboBox_da";
            this.comboBox_da.Size = new System.Drawing.Size(148, 31);
            this.comboBox_da.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường";
            // 
            // comboBox_duong
            // 
            this.comboBox_duong.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox_duong.FormattingEnabled = true;
            this.comboBox_duong.Location = new System.Drawing.Point(457, 106);
            this.comboBox_duong.Name = "comboBox_duong";
            this.comboBox_duong.Size = new System.Drawing.Size(148, 31);
            this.comboBox_duong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trà";
            // 
            // comboBox_tra
            // 
            this.comboBox_tra.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox_tra.FormattingEnabled = true;
            this.comboBox_tra.Location = new System.Drawing.Point(457, 166);
            this.comboBox_tra.Name = "comboBox_tra";
            this.comboBox_tra.Size = new System.Drawing.Size(148, 31);
            this.comboBox_tra.TabIndex = 1;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_confirm.Location = new System.Drawing.Point(247, 252);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(149, 45);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // soluong
            // 
            this.soluong.Font = new System.Drawing.Font("Arial", 12F);
            this.soluong.Location = new System.Drawing.Point(124, 40);
            this.soluong.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.soluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(147, 30);
            this.soluong.TabIndex = 4;
            this.soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_size
            // 
            this.comboBox_size.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(123, 107);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(148, 31);
            this.comboBox_size.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Size";
            // 
            // frmSelectDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 331);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.comboBox_tra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_duong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_da);
            this.Controls.Add(this.label1);
            this.Name = "frmSelectDrink";
            this.Text = "Chi tiết";
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_da;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_duong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tra;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown soluong;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label5;
    }
}