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
    public partial class backStage_playAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLConnection sqlconnection = new SQLConnection();
            //获取前台网页所提交的数据
            string movieNo = Request.Form["movieNo"];
            string movieName = Request.Form["movieName"];
            string hallName = Request.Form["hallName"];
            string playingDate = Request.Form["playingDate"];
            string time = Request.Form["time"];
            string hallNo = null;
            string sessionNo = null;

            sqlconnection.openDatabase();
            string sqlyuju1 = "select HallNo from VedioHalls where HallName ='" + hallName + "'";
            string sqlyuju2 = "select SessionNo from Schedual where Time ='" + time + "'";
            SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
            SqlDataReader sdr1 = cmd1.ExecuteReader();//创建数据读取器对象
            if (sdr1.Read())
            {
                hallNo = sdr1[0].ToString().Trim();
            }
            sdr1.Close();//查询出影厅名称对应的影厅编号

            SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
            SqlDataReader sdr2 = cmd2.ExecuteReader();//创建数据读取器对象
            if (sdr2.Read())
            {
                sessionNo = sdr2[0].ToString().Trim();
            }
            sdr2.Close();//查询出场次时间对应的场次号

            string sqlyuju3 = "select count(*) from MovieSchedual where HallNo = '" + hallNo + "' and SessionNo = '" + sessionNo + "' and PlayingDate = '" + playingDate + "'";
            SqlCommand cmd3 = sqlconnection.executeSQL(sqlyuju3);
            SqlDataReader sdr3 = cmd3.ExecuteReader();//创建数据读取器对象
            sdr3.Read();
            sdr3.Close();
            int n = (int)cmd3.ExecuteScalar();//传回第一行，赋给n

            if (n == 0)
            {//查询是否存在影片已在该日期该时间段该影厅，避免重复
                string sqlyuju4 = "insert into MovieSchedual(MovieNo,HallNo,SessionNo,PlayingDate) values('" + movieNo + "','" + hallNo + "','" + sessionNo + "','" + playingDate + "')";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju4);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('添加成功!');window.location.href ='backStage_playManagement.aspx'</script>");
            }
            else 
            {
                Response.Write("<script>alert('已有影片安排在当前日期当前时间当前影厅，请重新选择!')</script>");
            }
           
            sqlconnection.closeDatabase();
        }

    }
}