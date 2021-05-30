
namespace WinFormsApp1
{
    partial class RegisterForm
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
            this.label_pwd = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_pwdAgain = new System.Windows.Forms.Label();
            this.textBox_pwdAgain = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_pwd
            // 
            this.label_pwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pwd.Location = new System.Drawing.Point(127, 126);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(57, 27);
            this.label_pwd.TabIndex = 7;
            this.label_pwd.Text = "密码:";
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(107, 55);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(77, 27);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "用户名:";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_pwd.Location = new System.Drawing.Point(196, 126);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PlaceholderText = "请在此处输入密码";
            this.textBox_pwd.Size = new System.Drawing.Size(300, 30);
            this.textBox_pwd.TabIndex = 5;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Name.Location = new System.Drawing.Point(196, 55);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.PlaceholderText = "请在此处输入用户名";
            this.textBox_Name.Size = new System.Drawing.Size(300, 30);
            this.textBox_Name.TabIndex = 4;
            // 
            // label_pwdAgain
            // 
            this.label_pwdAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pwdAgain.AutoSize = true;
            this.label_pwdAgain.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pwdAgain.Location = new System.Drawing.Point(87, 194);
            this.label_pwdAgain.Name = "label_pwdAgain";
            this.label_pwdAgain.Size = new System.Drawing.Size(97, 27);
            this.label_pwdAgain.TabIndex = 11;
            this.label_pwdAgain.Text = "确认密码:";
            // 
            // textBox_pwdAgain
            // 
            this.textBox_pwdAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_pwdAgain.Location = new System.Drawing.Point(196, 194);
            this.textBox_pwdAgain.Name = "textBox_pwdAgain";
            this.textBox_pwdAgain.PlaceholderText = "请在此处输入密码";
            this.textBox_pwdAgain.Size = new System.Drawing.Size(300, 30);
            this.textBox_pwdAgain.TabIndex = 9;
            // 
            // label_email
            // 
            this.label_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(116, 258);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(68, 27);
            this.label_email.TabIndex = 13;
            this.label_email.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_email.Location = new System.Drawing.Point(196, 258);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.PasswordChar = '*';
            this.textBox_email.PlaceholderText = "请在此处输入Email";
            this.textBox_email.Size = new System.Drawing.Size(300, 30);
            this.textBox_email.TabIndex = 12;
            // 
            // button_Register
            // 
            this.button_Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Register.AutoSize = true;
            this.button_Register.BackColor = System.Drawing.Color.HotPink;
            this.button_Register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(217)))), ((int)(((byte)(241)))));
            this.button_Register.FlatAppearance.BorderSize = 0;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Register.ForeColor = System.Drawing.Color.White;
            this.button_Register.Location = new System.Drawing.Point(196, 340);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(300, 50);
            this.button_Register.TabIndex = 14;
            this.button_Register.Text = "提交";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 444);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_pwdAgain);
            this.Controls.Add(this.textBox_pwdAgain);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_pwdAgain;
        private System.Windows.Forms.TextBox textBox_pwdAgain;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_Register;
    }
}