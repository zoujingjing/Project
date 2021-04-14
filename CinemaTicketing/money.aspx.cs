using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CinemaTicketingSystem
{
    public partial class money : System.Web.UI.Page
    {
        protected string price;
        protected string message = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            price = (string)Session["price"];
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            //判断支付密码是否正确
            string payPassword = Request.Form["payPassword"];
            SQLConnection sqlconnection = new SQLConnection();
            try
            {
                string email = (string)Session["email"];
                
                sqlconnection.openDatabase();
                string sqlyuju = "SELECT count(*) FROM UserManagement WHERE Email = '" + email + "'and PayPassword = '" + payPassword + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器对象
                sdr.Read();
                sdr.Close();
                int n = (int)cmd.ExecuteScalar();//传回第一行，赋给n
                if (n >= 1)
                {
                    //生成相应的订单
                    string movieName = (string)Session["movieName"];
                    string playingDate = (string)Session["playingDate"];
                    string time = (string)Session["time"];
                    string hallName = (string)Session["hallName"];
                    string seat = (string)Session["seat"];
                    string statement = "未完成";
                    string customerName = null;
                    string generateDate = DateTime.Now.ToLongDateString().ToString(); //订单生成的日期
                    Session["generateDate"] = generateDate;

                    //生成订单号，订单号由支付成功时的当前物理时间组成
                    string orderNo1 = DateTime.Now.ToString("yyyy-MM-dd");
                    string orderNo2 = DateTime.Now.ToString("hh:mm:ss");
                    string orderNo = orderNo1 + orderNo2;

                    //提取字符串类型数据orderNo中的所有数字
                    string num = null;
                    foreach (char item in orderNo)
                    {
                        if (item >= 48 && item <= 57)
                        {
                            num += item;
                        }
                    }
                    orderNo = num;
                    Session["orderNo"] = orderNo;

                    try
                    {
                        sqlconnection.openDatabase();
                        string sqlyuju1 = "SELECT Name FROM UserManagement WHERE Email = '" + email + "'";
                        SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
                        SqlDataReader dr1 = cmd1.ExecuteReader();//创建数据读取器对象
                        if (dr1.Read())
                        {
                            customerName = dr1[0].ToString().Trim();
                            Session["customerName"] = customerName;
                        }
                            
                        dr1.Close();

                        string sqlyuju2 = "insert into Orders(OrderNo,MovieName,CusName,PlayingDate,Time,HallName,Seat,Price,Statement,GenerateDate) values('" + orderNo + "','" + movieName + "','" + customerName + "','" + playingDate + "','" + time + "','" + hallName + "','" + seat + "','" + price + "','" + statement + "','" + generateDate + "')";
                        SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
                        cmd2.ExecuteNonQuery();

                        sqlconnection.closeDatabase();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    Response.Write("<script>alert('支付成功!');window.location.href ='paymentSuccess.aspx'</script>");
                }
                else
                {
                    message = "支付密码错误！请重新输入!";

                }
                sqlconnection.closeDatabase();
            }
            catch (Exception ex)
            {
                throw ex;
            }


         }
    }
}