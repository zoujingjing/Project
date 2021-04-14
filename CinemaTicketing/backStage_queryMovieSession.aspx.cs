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
    public partial class backStage_queryMovieSession : System.Web.UI.Page
    {
        protected List<MovieSession> queryMovieSessionList = new List<MovieSession>();//用来存放查询的结果
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataSet dataSet = new DataSet();
            dataSet = (DataSet)Session["dataSet"];
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                MovieSession movieSession = new MovieSession();
                movieSession.setMovieNo(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                movieSession.setMovieName(dataSet.Tables[0].Rows[i][1].ToString().Trim());
                movieSession.setHallName(dataSet.Tables[0].Rows[i][2].ToString().Trim());
                movieSession.setPlayingDate(dataSet.Tables[0].Rows[i][3].ToString().Trim());
                movieSession.setTime(dataSet.Tables[0].Rows[i][4].ToString().Trim());

                queryMovieSessionList.Add(movieSession);
            }

            //点击删除按钮时
            string deleteHallName = Request.QueryString["deleteHallName"];
            string deletePlayingDate = Request.QueryString["deletePlayingDate"];
            string deleteTime = Request.QueryString["deleteTime"];
            Session["deleteHallName"] = deleteHallName;
            Session["deletePlayingDate"] = deletePlayingDate;
            Session["deleteTime"] = deleteTime;

            if (deleteHallName != null)
            {
                string strMsg = "确定要删除吗？";
                Session["request"] = "backStage_queryMovieSession";
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLConnection sqlconnection = new SQLConnection();
            string queryType = Request.Form["queryType"];
            sqlconnection.openDatabase();

            queryMovieSessionList.Clear();//清楚queryMovieSessionList中的所有元素

            if (queryType.Equals("影片编号"))
            {
                string movieNo = Request.Form["TextBox1"];
                int result = -1;
                if (isNumberic(movieNo, result))
                {
                    string sqlyuju2 = "Select MovieSchedual.MovieNo,MovieName,HallName,PlayingDate,Time from Movies,MovieSchedual,Schedual,VedioHalls" + " where Movies.MovieNo = MovieSchedual.MovieNo and MovieSchedual.SessionNo = Schedual.SessionNo and MovieSchedual.HallNo = VedioHalls.HallNo and MovieSchedual.MovieNo= '" + movieNo + "'" + "order by PlayingDate asc,Time asc";
                    SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            Session["dataSet"] = dataSet;
                            Response.Redirect("/backStage_queryMovieSession.aspx");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('抱歉，没有查找到该影片的放映信息！');</script>");
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
                    string sqlyuju3 = "Select MovieSchedual.MovieNo,MovieName,HallName,PlayingDate,Time from Movies,MovieSchedual,Schedual,VedioHalls" + " where Movies.MovieNo = MovieSchedual.MovieNo and MovieSchedual.SessionNo = Schedual.SessionNo and MovieSchedual.HallNo = VedioHalls.HallNo and MovieName= '" + movieName + "'" + "order by PlayingDate asc,Time asc";
                    SqlCommand cmd3 = sqlconnection.executeSQL(sqlyuju3);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            Session["dataSet"] = dataSet;
                            Response.Redirect("/backStage_queryMovieSession.aspx");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('抱歉，没有查找到该影片的放映信息！');</script>");
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