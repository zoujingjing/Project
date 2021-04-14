using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CinemaTicketingSystem.Entity;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CinemaTicketingSystem
{
    public partial class backStage_orderManagement : System.Web.UI.Page
    {
        protected List<Orders> ordersList = new List<Orders>();
        protected Orders queryOrder = new Orders();
        SQLConnection sqlconnection = new SQLConnection();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlconnection.openDatabase();
            string sqlyuju1 = "select * from Orders";
            SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Orders orders = new Orders();
                orders.setOrderNo(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                orders.setMovieName(dataSet.Tables[0].Rows[i][1].ToString().Trim());
                orders.setCustomerName(dataSet.Tables[0].Rows[i][2].ToString().Trim());
                orders.setPlayingDate(dataSet.Tables[0].Rows[i][3].ToString().Trim());
                orders.setTime(dataSet.Tables[0].Rows[i][4].ToString().Trim());
                orders.setHallName(dataSet.Tables[0].Rows[i][5].ToString().Trim());
                orders.setSeat(dataSet.Tables[0].Rows[i][6].ToString().Trim());
                orders.setPrice(dataSet.Tables[0].Rows[i][7].ToString().Trim());
                orders.setStatement(dataSet.Tables[0].Rows[i][8].ToString().Trim());
                orders.setGenerateDate(dataSet.Tables[0].Rows[i][9].ToString().Trim());

                ordersList.Add(orders);
            }


            //点击删除按钮时
            string deleteOrderNo = Request.QueryString["deleteOrderNo"];
            Session["deleteOrderNo"] = deleteOrderNo;
            if (deleteOrderNo != null)
            {
                string strMsg = "确定要删除吗？";
                Session["request"] = "backStage_orderManagement";
                Response.Write("<Script Language='JavaScript'>if ( window.confirm('" + strMsg + "')) {alert('删除成功!');window.location.href ='executeDeleteSql.aspx'} else {history.back();};</script>");
            }

        }


        protected bool isNumberic(string message, int result)
        {
            //判断是否为整数字符串
            //是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false
            result = -1;   //result 定义为out 用来输出值
            try
            {
                //当数字字符串的位数少于4时，以下三种都可以转换，任选一种
                //如果位数超过4的话，请选用Convert.ToInt32() 和int.Parse()

                //result = int.Parse(message);
                //result = Convert.ToInt16(message);
                result = Convert.ToInt32(message);
                return true;
            }
            catch
            {
                return false;
            }
        }


        //查询
        protected void Button1_Click(object sender, EventArgs e)
        {
            string queryType = Request.Form["queryType"];
            sqlconnection.openDatabase();

            if (queryType.Equals("订单编号"))
            {
                string orderNo = Request.Form["TextBox1"];
                int result = -1;
                if (isNumberic(orderNo, result))
                {
                    string sqlyuju2 = "Select * from Orders" + " where OrderNo= '" + orderNo + "'";
                    SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        Session["dataSet"] = dataSet;
                        Response.Redirect("/backStage_queryOrder.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('抱歉，没有查找到有关该订单的信息！');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('输入的索引与查找类型不一致！');</script>");
                }

            }
            else if (queryType.Equals("影片名称"))
            {
                string movieName = Request.Form["TextBox1"];
                int result = -1;
                if (!(isNumberic(movieName, result)))
                {
                    string sqlyuju3 = "Select * from Orders" + " where MovieName= '" + movieName + "'";
                    SqlCommand cmd3 = sqlconnection.executeSQL(sqlyuju3);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        Session["dataSet"] = dataSet;
                        Response.Redirect("/backStage_queryOrder.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('抱歉，没有查找到有关该订单的信息！');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('输入的索引与查找类型不一致！');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请选择查询类型！');</script>");
            }
        }
    }
}