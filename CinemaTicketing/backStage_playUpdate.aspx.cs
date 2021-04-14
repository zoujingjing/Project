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
    public partial class backStage_playUpdate : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string old_hallName;
        protected string old_playingDate;
        protected string old_time;
        protected string old_movieNo;
        protected string old_movieName;
        protected string old_hallNo;//原来的影厅编号
        protected string old_sessionNo;//原来的场次号
        
        protected void Page_Load(object sender, EventArgs e)
        {
            old_hallName = Request.QueryString["hallName"];
            old_playingDate = Request.QueryString["playingDate"];
            old_time = Request.QueryString["time"];

            sqlconnection.openDatabase();
            string sqlyuju = "Select MovieSchedual.MovieNo,MovieName,MovieSchedual.HallNo,HallName,PlayingDate,MovieSchedual.SessionNo,Time from Movies,MovieSchedual,Schedual,VedioHalls" + " where Movies.MovieNo = MovieSchedual.MovieNo and MovieSchedual.SessionNo = Schedual.SessionNo and MovieSchedual.HallNo = VedioHalls.HallNo and HallName = '" + old_hallName + "'" + "and playingDate = '" + old_playingDate + "'" + "and Time = '" + old_time + "'";
            SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                old_movieNo = (string)dr[0].ToString().Trim();
                old_movieName = (string)dr[1].ToString().Trim();
                old_hallNo = (string)dr[2].ToString().Trim();
                old_sessionNo = (string)dr[5].ToString().Trim();
            }
            sqlconnection.closeDatabase();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //获取前台网页所提交的数据
            string movieName = Request.Form["movieName"];
            string playingDate = Request.Form["playingDate"];
            string hallName = Request.Form["hallName"];
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
            sdr1.Close();

            SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
            SqlDataReader sdr2 = cmd2.ExecuteReader();//创建数据读取器对象
            if (sdr2.Read())
            {
                sessionNo = sdr2[0].ToString().Trim();
            }
            sdr2.Close();

            string sqlyuju3 = "select count(*) from MovieSchedual where HallNo = '" + hallNo + "' and SessionNo = '" + sessionNo + "' and PlayingDate = '" + playingDate + "'";
            SqlCommand cmd3 = sqlconnection.executeSQL(sqlyuju3);
            SqlDataReader sdr3 = cmd3.ExecuteReader();//创建数据读取器对象
            sdr3.Read();
            sdr3.Close();
            int n = (int)cmd3.ExecuteScalar();//传回第一行，赋给n

            if (n == 0)
            {//查询是否存在影片已在该日期该时间段该影厅，避免重复

                string sqlyuju4 = "update MovieSchedual set HallNo='" + hallNo + "',SessionNo = '" + sessionNo + "',PlayingDate='" + playingDate + "' where HallNo = '" + old_hallNo + "' and SessionNo = '" + old_sessionNo + "' and PlayingDate = '" + old_playingDate + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju4);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('修改成功!');window.location.href ='backStage_playManagement.aspx'</script>");
            }
            else 
            {
                Response.Write("<script>alert('已有影片安排在当前日期当前时间当前影厅，请重新选择!')</script>");
            }
           
            sqlconnection.closeDatabase();
            
         }
    }
}