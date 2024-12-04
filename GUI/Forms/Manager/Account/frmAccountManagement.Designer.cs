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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_taiKhoan = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(312, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // dgv_taiKhoan
            // 
            this.dgv_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taiKhoan.Location = new System.Drawing.Point(25, 204);
            this.dgv_taiKhoan.Name = "dgv_taiKhoan";
            this.dgv_taiKhoan.RowHeadersWidth = 51;
            this.dgv_taiKhoan.RowTemplate.Height = 24;
            this.dgv_taiKhoan.Size = new System.Drawing.Size(819, 326);
            this.dgv_taiKhoan.TabIndex = 37;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(25, 130);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(380, 22);
            this.txt_Search.TabIndex = 40;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(452, 130);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 582);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_taiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "frmAccountManagement";
            this.Text = "frmAccountManagement";
            this.Load += new System.EventHandler(this.frmAccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_taiKhoan;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_search;
    }
}