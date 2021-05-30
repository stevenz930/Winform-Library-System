using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }


        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)//当关闭窗口后终止进程
        {
            Application.Exit();
        }
    }
}
