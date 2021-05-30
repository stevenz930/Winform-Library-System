using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)//当关闭窗口后终止进程
        {
            Application.Exit();
        }

        private void 注销_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Hide();
            loginform.Show();
        }

        private void MainFormUser_Load(object sender, EventArgs e)
        {
            MySqlDbHelper mySqlDbHelper = new MySqlDbHelper();
            mySqlDbHelper.GetConnection();
        }
    }
}
