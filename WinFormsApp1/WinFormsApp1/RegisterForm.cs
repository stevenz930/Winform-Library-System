using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            string username = textBox_Name.Text;//获取用户名
            string password = textBox_pwd.Text;//获取密码
            string passwordA = textBox_pwdAgain.Text;//获取密码
            string email = textBox_email.Text;//获取密码
            if (username == "")//检测ID栏是否为空
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            else if (password == "")//检测密码栏是否为空
            {
                MessageBox.Show("请输入密码");
                return;
            }
            else if (passwordA == "")//检测密码栏是否为空
            {
                MessageBox.Show("请再次输入密码");
                return;
            }
            else if (email == "")//检测密码栏是否为空
            {
                MessageBox.Show("请输入电子邮箱");
                return;
            }
            else
            {

            }
            //检查用户名、密码、邮箱是否符合条件
            //展示输入的内容
            //询问是否确定
            //Yes写入数据库
            //关闭注册界面
            //No关闭询问界面

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LoginForm loginform = new LoginForm();
            //loginform.Show();
        }
    }
}
