using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)//当登陆界面加载时关闭其余页面
        {
            MySqlDbHelper mySqlDbHelper = new MySqlDbHelper();
            mySqlDbHelper.GetConnection();
            MainFormUser mainForm = new MainFormUser();
            mainForm.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//跳转注册界面
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void button_Login_Click(object sender, EventArgs e)//登录按钮;跳转主界面
        {
            string userid = textBox_ID.Text;//获取用户ID
            string password = textBox_pwd.Text;//获取密码
            if (userid == "")//检测ID栏是否为空
            {
                MessageBox.Show("请输入用户ID");
                return;
            }
            else if (password == "")//检测密码栏是否为空
            {
                MessageBox.Show("请输入密码");
                return;
            }
            else//都不为空则尝试登录
            {
                MySqlDbHelper mySqlDbHelper = new MySqlDbHelper();
                string sql = "select count(*) from User where uID='{0}' and uPwd='{1}'";//认证id和密码是否匹配
                sql = string.Format(sql, userid, password);

                string sql2 = "select uName from User where uID='{0}' and uPwd='{1}'";//获取用户名
                sql2 = string.Format(sql2, userid, password);

                string sql3 = "select uPower from User where uID='{0}' and uPwd='{1}'";//获取权限等级
                sql3 = string.Format(sql3, userid, password);

                //string sql4 = "select uPower,uName from User where uID='{0}' and uPwd='{1}'";//获取权限等级
                //sql4 = string.Format(sql4, userid, password);
                //var tuple = mySqlDbHelper.ExecuteReader(sql4);
                //MessageBox.Show("登陆成功!\n欢迎你," + tuple.Item1 + "级用户  " + tuple.Item2 + "  !");

                long i = (long)mySqlDbHelper.ExecuteScalar(sql, out _);
                if (i > 0)
                {
                    string username = mySqlDbHelper.ExecuteScalar(sql2, out _).ToString();//获取用户名
                    string power = mySqlDbHelper.ExecuteScalar(sql3, out _).ToString();//获取权限等级
                    switch (power)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                            MessageBox.Show("登陆成功!\n欢迎你," + power + "级用户  " + username + "  !");
                            break;
                        case "99":
                            MessageBox.Show("登陆成功!\n欢迎你,管理员" + username + "  !");
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("登陆失败!");
                    return;
                }
            }

            MainFormUser mainForm = new MainFormUser();
            mainForm.Show();

            this.Hide();
        }
    }
}
