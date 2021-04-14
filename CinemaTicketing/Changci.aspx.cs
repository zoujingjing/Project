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
    public partial class Changci : System.Web.UI.Page
    {
        //protected Entity.Movies mov = new Entity.Movies();
        protected List<Entity.MovieSession> sessionList = new List<Entity.MovieSession>();  //创建一个列表用来存放电影场次列表
        SQLConnection sqlconnection = new SQLConnection();
        protected Boolean flag = true;
        protected List<int> countList = new List<int>();  //创建一个列表用来存放每个日期的上映次数
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlyuju1 = null;
            string sqlyuju2 = null;
            sqlconnection.openDatabase();//打开数据库

            string movieName = Request.QueryString["content"];
            sqlyuju1 = "Select MovieName,Type,Price,PlayingDate,Time,HallName,HallType from Movies,MovieSchedual,Schedual,VedioHalls" + " where Movies.MovieNo = MovieSchedual.MovieNo and MovieSchedual.SessionNo = Schedual.SessionNo and MovieSchedual.HallNo = VedioHalls.HallNo and MovieName= '" + movieName + "'"+"order by PlayingDate asc,Time asc";
            sqlyuju2 = "Select count(*) from Movies,MovieSchedual,Schedual,VedioHalls" + " where Movies.MovieNo = MovieSchedual.MovieNo and MovieSchedual.SessionNo = Schedual.SessionNo and MovieSchedual.HallNo = VedioHalls.HallNo and MovieName= '" + movieName + "'" + "group by PlayingDate";
            SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
            SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Entity.MovieSession movSession = new Entity.MovieSession();
                movSession.setMovieName(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                movSession.setType(dataSet.Tables[0].Rows[i][1].ToString().Trim());
                movSession.setPrice(dataSet.Tables[0].Rows[i][2].ToString().Trim());
                movSession.setPlayingDate(dataSet.Tables[0].Rows[i][3].ToString().Trim());
                movSession.setTime(dataSet.Tables[0].Rows[i][4].ToString().Trim());
                movSession.setHallName(dataSet.Tables[0].Rows[i][5].ToString().Trim());
                movSession.setHallType(dataSet.Tables[0].Rows[i][6].ToString().Trim());

                sessionList.Add(movSession);
                
            }

            SqlDataReader dr = cmd2.ExecuteReader();

            if (dr.HasRows)
            {
                //读取多个结果集
                //用do--while方法，do中先读取第一个结果集，while中读取第二个结果集，依次循环
                do
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {

                                countList.Add((int)dr.GetValue(i));
                            }
                        }
                    }
                }
                while (dr.NextResult());
            }
            dr.Close();
            sqlconnection.closeDatabase();//关闭数据库
        }
    }
}