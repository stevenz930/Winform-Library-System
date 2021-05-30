
namespace WinFormsApp1
{
    partial class LoginForm
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_ID.Location = new System.Drawing.Point(115, 123);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.PlaceholderText = "请在此处输入账号";
            this.textBox_ID.Size = new System.Drawing.Size(192, 23);
            this.textBox_ID.TabIndex = 0;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_pwd.Location = new System.Drawing.Point(115, 174);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.PlaceholderText = "请在此处输入密码";
            this.textBox_pwd.Size = new System.Drawing.Size(192, 23);
            this.textBox_pwd.TabIndex = 1;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ID.Location = new System.Drawing.Point(71, 123);
            this.label_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(37, 20);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "账号";
            // 
            // label_pwd
            // 
            this.label_pwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pwd.Location = new System.Drawing.Point(71, 174);
            this.label_pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(37, 20);
            this.label_pwd.TabIndex = 3;
            this.label_pwd.Text = "密码";
            // 
            // button_Login
            // 
            this.button_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Login.AutoSize = true;
            this.button_Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(115, 235);
            this.button_Login.Margin = new System.Windows.Forms.Padding(2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(191, 35);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Register.Location = new System.Drawing.Point(8, 279);
            this.linkLabel_Register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(56, 17);
            this.linkLabel_Register.TabIndex = 8;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "注册账号";
            this.linkLabel_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // label_Logo
            // 
            this.label_Logo.BackColor = System.Drawing.Color.Transparent;
            this.label_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Logo.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Logo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_Logo.Location = new System.Drawing.Point(0, 0);
            this.label_Logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(400, 104);
            this.label_Logo.TabIndex = 7;
            this.label_Logo.Text = "Login";
            this.label_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 314);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
        
    }
}