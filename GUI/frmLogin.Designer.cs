namespace GUI
{
    partial class frmLogin
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.txtBox_Login = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.btn_LoginSubmit = new System.Windows.Forms.Button();
            this.checkBox_RememberLogin = new System.Windows.Forms.CheckBox();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(89, 26);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(332, 45);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Đăng nhập tài khoản";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(25, 108);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(103, 28);
            this.lb_Username.TabIndex = 1;
            this.lb_Username.Text = "Username:";
            // 
            // txtBox_Login
            // 
            this.txtBox_Login.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Login.Location = new System.Drawing.Point(154, 105);
            this.txtBox_Login.Name = "txtBox_Login";
            this.txtBox_Login.Size = new System.Drawing.Size(328, 34);
            this.txtBox_Login.TabIndex = 2;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(25, 176);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(98, 28);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Password.Location = new System.Drawing.Point(154, 173);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(328, 34);
            this.txtBox_Password.TabIndex = 4;
            // 
            // btn_LoginSubmit
            // 
            this.btn_LoginSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginSubmit.Location = new System.Drawing.Point(154, 276);
            this.btn_LoginSubmit.Name = "btn_LoginSubmit";
            this.btn_LoginSubmit.Size = new System.Drawing.Size(148, 41);
            this.btn_LoginSubmit.TabIndex = 5;
            this.btn_LoginSubmit.Text = "Đăng nhập";
            this.btn_LoginSubmit.UseVisualStyleBackColor = true;
            // 
            // checkBox_RememberLogin
            // 
            this.checkBox_RememberLogin.AutoSize = true;
            this.checkBox_RememberLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RememberLogin.Location = new System.Drawing.Point(154, 233);
            this.checkBox_RememberLogin.Name = "checkBox_RememberLogin";
            this.checkBox_RememberLogin.Size = new System.Drawing.Size(181, 27);
            this.checkBox_RememberLogin.TabIndex = 6;
            this.checkBox_RememberLogin.Text = "Ghi nhớ đăng nhập";
            this.checkBox_RememberLogin.UseVisualStyleBackColor = true;
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.lb_Title);
            this.panel_Container.Controls.Add(this.checkBox_RememberLogin);
            this.panel_Container.Controls.Add(this.lb_Username);
            this.panel_Container.Controls.Add(this.btn_LoginSubmit);
            this.panel_Container.Controls.Add(this.txtBox_Login);
            this.panel_Container.Controls.Add(this.txtBox_Password);
            this.panel_Container.Controls.Add(this.lb_Password);
            this.panel_Container.Location = new System.Drawing.Point(12, 12);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(496, 348);
            this.panel_Container.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 370);
            this.Controls.Add(this.panel_Container);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập Tài Khoản";
            this.panel_Container.ResumeLayout(false);
            this.panel_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox txtBox_Login;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Button btn_LoginSubmit;
        private System.Windows.Forms.CheckBox checkBox_RememberLogin;
        private System.Windows.Forms.Panel panel_Container;
    }
}

