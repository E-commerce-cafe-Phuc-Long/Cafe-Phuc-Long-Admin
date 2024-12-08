namespace GUI.Forms.Manager.Account
{
    partial class frmAccountManagement
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
            this.lb_title = new System.Windows.Forms.Label();
            this.dgv_taiKhoan = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_title.Location = new System.Drawing.Point(328, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(314, 46);
            this.lb_title.TabIndex = 36;
            this.lb_title.Text = "Quản Lý Tài Khoản";
            // 
            // dgv_taiKhoan
            // 
            this.dgv_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taiKhoan.Location = new System.Drawing.Point(28, 154);
            this.dgv_taiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_taiKhoan.Name = "dgv_taiKhoan";
            this.dgv_taiKhoan.RowHeadersWidth = 51;
            this.dgv_taiKhoan.RowTemplate.Height = 24;
            this.dgv_taiKhoan.Size = new System.Drawing.Size(935, 322);
            this.dgv_taiKhoan.TabIndex = 37;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(28, 94);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(427, 30);
            this.txt_Search.TabIndex = 40;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(492, 88);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(135, 41);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 504);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_taiKhoan);
            this.Controls.Add(this.lb_title);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccountManagement";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmAccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridView dgv_taiKhoan;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_search;
    }
}