using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using CinemaTicketingSystem.Entity;

namespace CinemaTicketingSystem
{
    public partial class personCenter_myOrders : System.Web.UI.Page
    {
        protected Orders mov = new Orders();
        protected List<string> orderNoList1 = new List<string>();  //创建一个列表用来存放未完成订单编号
        protected List<string> orderNoList2 = new List<string>();  //创建一个列表用来存放已完成订单编号
        protected List<Orders> list1 = new List<Orders>();  //创建一个列表用来存放未完成订单
        protected List<Orders> list2 = new List<Orders>();  //创建一个列表用来存放已完成订单
        SQLConnection sqlconnection = new SQLConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)Session["username"];

            {//显示电影列表
                sqlconnection.openDatabase();//打开数据库
                //联合Orders表和UserManagement表，根据用户名查询该用户的未完成订单编号
                string sqlyuju1 = "select OrderNo from Orders,UserManagement where Cusname=Name and Username='" + username + "' and Statement='未完成'; ";
                SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.HasRows)
                {
                    //读取多个结果集
                    //用do--while方法，do中先读取第一个结果集，while中读取第二个结果集，依次循环
                    do
                    {
                        if (dr1.HasRows)
                        {
                            while (dr1.Read())
                            {
                                for (int i = 0; i < dr1.FieldCount; i++)
                                {
                                    orderNoList1.Add((string)dr1.GetValue(i));//将读取到的某一条记录添加到orderNoList1中
                                }
                            }
                        }
                    }
                    while (dr1.NextResult());
                }
                dr1.Close();
                sqlconnection.closeDatabase();//关闭数据库
            }

            {
                sqlconnection.openDatabase();//打开数据库
                //联合Orders表和UserManagement表，根据用户名查询该用户的已完成订单编号
                string sqlyuju2 = "select OrderNo from Orders,UserManagement where Cusname=Name and Username='" + username + "' and Statement='已完成'; ";
                SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.HasRows)
                {
                    //读取多个结果集
                    do
                    {
                        if (dr2.HasRows)
                        {
                            while (dr2.Read())
                            {
                                for (int i = 0; i < dr2.FieldCount; i++)
                                {
                                    orderNoList2.Add((string)dr2.GetValue(i));//将读取到的某一条记录添加到orderNoList2中
                                }
                            }
                        }
                    }
                    while (dr2.NextResult());
                }
                dr2.Close();
                sqlconnection.closeDatabase();//关闭数据库
            }



            {
                sqlconnection.openDatabase();//打开数据库
                //根据orderNoList1中的所有订单编号来查询出该用户的所有未完成订单信息
                for (int i = 0; i < orderNoList1.Count(); i++)
                {
                    //根据orderNoList1中的一项，查询某个订单的全部信息
                    string sqlyuju3 = "Select * from Orders where OrderNo='" + orderNoList1[i] + "'";
                    SqlCommand cmd3 = sqlconnection.executeSQL(sqlyuju3);
                    SqlDataReader dr3 = cmd3.ExecuteReader();

                    //Orders order = new Orders();

                    if (dr3.Read())
                    {
                        Orders order = new Orders();//创建一个新的Order对象
                        //将读取到的数据赋值给新建Orders对象
                        order.setOrderNo((string)dr3[0].ToString().Trim());
                        order.setMovieName((string)dr3[1].ToString().Trim());
                        order.setCustomerName((string)dr3[2].ToString().Trim());
                        order.setPlayingDate((string)dr3[3].ToString().Trim());
                        order.setTime((string)dr3[4].ToString().Trim());
                        order.setHallName((string)dr3[5].ToString().Trim());
                        order.setSeat((string)dr3[6].ToString().Trim());
                        order.setPrice((string)dr3[7].ToString().Trim());
                        order.setStatement((string)dr3[8].ToString().Trim());
                        order.setGenerateDate((string)dr3[9].ToString().Trim());

                        list1.Add(order);//将此Orders对象添加到list1中
                    }
                    dr3.Close();
                }

                //根据orderNoList2中的所有订单编号来查询出该用户的所有未完成订单信息
                for (int i = 0; i < orderNoList2.Count(); i++)
                {
                    //根据orderNoList2中的一项，查询某个订单的全部信息
                    string sqlyuju4 = "Select * from Orders where OrderNo='" + orderNoList2[i] + "'";
                    SqlCommand cmd4 = sqlconnection.executeSQL(sqlyuju4);
                    SqlDataReader dr4 = cmd4.ExecuteReader();

                    //Orders order = new Orders();

                    if (dr4.Read())
                    {
                        Orders order = new Orders();//创建一个新的Order对象
                        //将读取到的数据赋值给新建Orders对象
                        order.setOrderNo((string)dr4[0].ToString().Trim());
                        order.setMovieName((string)dr4[1].ToString().Trim());
                        order.setCustomerName((string)dr4[2].ToString().Trim());
                        order.setPlayingDate((string)dr4[3].ToString().Trim());
                        order.setTime((string)dr4[4].ToString().Trim());
                        order.setHallName((string)dr4[5].ToString().Trim());
                        order.setSeat((string)dr4[6].ToString().Trim());
                        order.setPrice((string)dr4[7].ToString().Trim());
                        order.setStatement((string)dr4[8].ToString().Trim());
                        order.setGenerateDate((string)dr4[9].ToString().Trim());

                        list2.Add(order);//将此Orders对象添加到list2中
                    }
                    dr4.Close();
                }

                sqlconnection.closeDatabase();//关闭数据库
            }

            //打印，模拟线下取票
            {
                string orderNo = Request.QueryString["orderNo"];
                if (orderNo != null) 
                {
                    string statement = "已完成";
                    sqlconnection.openDatabase();//打开数据库
                    string sqlyuju = "update Orders set Statement = '" + statement + "' where OrderNo = '" + orderNo + "';";
                    SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('打印成功!');window.location.href ='personCenter_myOrders.aspx'</script>");//返回个人信息页面
                    sqlconnection.closeDatabase();//关闭数据库
                }
                
            }

        }
    }
}