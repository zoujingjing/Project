using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loginaccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = textBox1.Text.Trim();
                string PassWord = textBox2.Text.Trim();
                if (UserName == "")
                {
                    MessageBox.Show("用户名为空，请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (PassWord == "")
                {
                    MessageBox.Show("密码为空，请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string str = "SELECT count(*) FROM Users WHERE username = '" + UserName + "'and password = '" + PassWord + "'";
                    //定义一个数据库连接的字符串对象
                    string connectionStr = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MYDB;Integrated Security=True";
                    //建立一个数据库连接对象
                    SqlConnection conn = new SqlConnection(connectionStr);
                    //创建一个命令对象
                    SqlCommand cmd = new SqlCommand(str, conn);
                    conn.Open();//如果一个连接对象打开，那么必须在try最后关闭它
                    Console.WriteLine("数据连接成功打开");

                    SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器对象
                    sdr.Read();
                    sdr.Close();
                    int n = (int)cmd.ExecuteScalar();//传回第一行，赋给n
                    if (n >= 1)
                    {
                        MessageBox.Show("success!");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);//弹出警告提示，密码不对
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//打印异常
            }
         }
      }
}
