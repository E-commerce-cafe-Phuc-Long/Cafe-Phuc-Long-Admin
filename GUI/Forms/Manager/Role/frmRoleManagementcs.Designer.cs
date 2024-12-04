namespace GUI.Forms.Manager.Role
{
    partial class frmRoleManagement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txt_maVaiTro = new System.Windows.Forms.TextBox();
            this.txt_tenVaiTro = new System.Windows.Forms.TextBox();
            this.dgv_VaiTro = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Location = new System.Drawing.Point(571, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 227);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(66, 114);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(66, 75);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(66, 31);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(39, 157);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(132, 23);
            this.btn_Clear.TabIndex = 38;
            this.btn_Clear.Text = "Hiển thị tất cả";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(216, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 34);
            this.label1.TabIndex = 46;
            this.label1.Text = "Quản lý vai trò";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.txt_maVaiTro);
            this.groupBox1.Controls.Add(this.txt_tenVaiTro);
            this.groupBox1.Location = new System.Drawing.Point(32, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 155);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điền các thông tin";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(6, 37);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(74, 16);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Mã vai trò : ";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(6, 93);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 16);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Tên vai trò :";
            // 
            // txt_maVaiTro
            // 
            this.txt_maVaiTro.Location = new System.Drawing.Point(165, 31);
            this.txt_maVaiTro.Name = "txt_maVaiTro";
            this.txt_maVaiTro.Size = new System.Drawing.Size(316, 22);
            this.txt_maVaiTro.TabIndex = 10;

            // 
            // txt_tenVaiTro
            // 
            this.txt_tenVaiTro.Location = new System.Drawing.Point(165, 87);
            this.txt_tenVaiTro.Name = "txt_tenVaiTro";
            this.txt_tenVaiTro.Size = new System.Drawing.Size(316, 22);
            this.txt_tenVaiTro.TabIndex = 13;
            // 
            // dgv_VaiTro
            // 
            this.dgv_VaiTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VaiTro.Location = new System.Drawing.Point(30, 355);
            this.dgv_VaiTro.Name = "dgv_VaiTro";
            this.dgv_VaiTro.RowHeadersWidth = 51;
            this.dgv_VaiTro.RowTemplate.Height = 24;
            this.dgv_VaiTro.Size = new System.Drawing.Size(741, 265);
            this.dgv_VaiTro.TabIndex = 44;
            // 
            // frmRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_VaiTro);
            this.Name = "frmRoleManagement";
            this.Text = "frmRoleManagementcs";
            this.Load += new System.EventHandler(this.frmRoleManagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VaiTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txt_maVaiTro;
        private System.Windows.Forms.TextBox txt_tenVaiTro;
        private System.Windows.Forms.DataGridView dgv_VaiTro;
    }
}