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
    public partial class executeDeleteSql : System.Web.UI.Page
    {
        protected string re;
        protected string deleteorderno;

        protected void Page_Load(object sender, EventArgs e)
        {
            SQLConnection sqlconnection = new SQLConnection();
            string request = (string)Session["request"];
            
            re = request;

            if(request.Equals("backStage_movieManagement"))
            {//影片管理的删除
                //执行删除的sql语句的函数
                string deleteMovieNo = (string)Session["deleteMovieNo"];
                sqlconnection.openDatabase();
                string sqlyuju = "Delete from Movies where MovieNo = '" + deleteMovieNo + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                cmd.ExecuteNonQuery();

                sqlconnection.closeDatabase();

                Response.Redirect("backStage_movieManagement.aspx");
            }

            if (request.Equals("backStage_playManagement") || request.Equals("backStage_queryMovieSession"))
            {//放映管理的删除
                string deleteHallName = (string)Session["deleteHallName"];
                string deletePlayingDate = (string)Session["deletePlayingDate"];
                string deleteTime = (string)Session["deleteTime"];

                sqlconnection.openDatabase();
                string hallNo = null;
                string sessionNo = null;
                string sqlyuju11 = "select HallNo from VedioHalls where HallName ='" + deleteHallName + "'";
                string sqlyuju22 = "select SessionNo from Schedual where Time ='" + deleteTime + "'";
                SqlCommand cmd11 = sqlconnection.executeSQL(sqlyuju11);
                SqlDataReader sdr11 = cmd11.ExecuteReader();//创建数据读取器对象
                if (sdr11.Read())
                {
                    hallNo = sdr11[0].ToString().Trim();
                }
                sdr11.Close();

                SqlCommand cmd22 = sqlconnection.executeSQL(sqlyuju22);
                SqlDataReader sdr22 = cmd22.ExecuteReader();//创建数据读取器对象
                if (sdr22.Read())
                {
                    sessionNo = sdr22[0].ToString().Trim();
                }
                sdr22.Close();

                string sqlyuju = "Delete from MovieSchedual where HallNo = '" + hallNo + "' and SessionNo = '" + sessionNo + "' and PlayingDate = '" + deletePlayingDate + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                cmd.ExecuteNonQuery();
                sqlconnection.closeDatabase();

                if (request.Equals("backStage_playManagement")) { Response.Redirect("backStage_playManagement.aspx"); }
                else { Response.Redirect("backStage_queryMovieSession.aspx"); }
            }

            if (request.Equals("backStage_orderManagement") || request.Equals("backStage_queryOrder")) 
            {//订单管理的删除
                string deleteOrderNo = (string)Session["deleteOrderNo"];
                deleteorderno = deleteOrderNo;
                sqlconnection.openDatabase();
                string sqlyuju = "Delete from Orders where OrderNo = '" + deleteOrderNo + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                cmd.ExecuteNonQuery();

                sqlconnection.closeDatabase();
                if (request.Equals("backStage_orderManagement")) { Response.Redirect("backStage_orderManagement.aspx"); }
                else { Response.Redirect("backStage_queryOrder.aspx"); }
            }

        }
    }
}