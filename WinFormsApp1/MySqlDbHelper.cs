using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class MySqlDbHelper
    {
        public MySqlConnection conn = null;
        public MySqlCommand result = null;
        public MySqlDataReader dataRead = null;
        public string connStr = "server=39.101.140.146;persistsecurityinfo=True;user id=z2xh_database;password='zx5KRyaDGDmBsD4L';database=z2xh_database;port=3306;allowuservariables=True";


        public MySqlConnection GetConnection()//检测是否已经连接数据库,若否则连接
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            if (conn.State == ConnectionState.Open)
            {
                //MessageBox.Show("数据库已连接！");
            }
            else
            {
                MessageBox.Show("正在尝试连接数据库！");
                try
                {
                    conn.Open();
                    MessageBox.Show("数据库已连接！");
                }
                catch
                {
                    MessageBox.Show("数据库连接失败！\n请检查网络，正在退出程序！");
                    Application.Exit();
                }
            }
            return conn;
        }
        
        ///
        /// 执行增删改SQL语句或存储过程
        ///
        public int ExecuteNonQuery(string cmdText)
        {
            //cmd.CommandText = cmdText;
            //int result = cmd.ExecuteNonQuery();
            return 1;
        }

        ///
        /// 执行查询SQL语句,返回2个
        ///
        public Tuple<string,string> ExecuteReader(string cmdText)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            conn.Open();
            dataRead = cmd.ExecuteReader();

            dataRead.Read();
            string rd0 = dataRead[0].ToString();
            string rd1 = dataRead[1].ToString();
            Tuple<string, string> tup = new Tuple<string, string>(rd0, rd1);
            conn.Close();
            return tup;
            /*
            if (dataRead.Read())
            {
                string rd0 = dataRead[0].ToString();
                string rd1 = dataRead[1].ToString();
                Tuple<string, string> tup = new Tuple<string, string>(rd0, rd1);
                conn.Close();
                return tup;
            }
            else
            {
                string rd0 = null;
                string rd1 = null;
                Tuple<string, string> tup = new Tuple<string, string>(rd0, rd1);
                conn.Close();
                return tup;
            }
            */
        }

        ///
        /// 执行查询SQL语句,返回单个
        ///
        public object ExecuteScalar(string cmdText,out string rd)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            rd = result.ToString();
            conn.Close();
            return result;
        }
    }
}
