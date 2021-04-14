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
    public partial class movieDetail : System.Web.UI.Page
    {
        protected Entity.Movies mov = new Entity.Movies();
        protected List<string> list = new List<string>();  //创建一个列表用来存放电影名称
        SQLConnection sqlconnection = new SQLConnection();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            {//显示电影列表
                string sqlyuju = null;
                sqlconnection.openDatabase();//打开数据库

                sqlyuju = "select MovieName from Movies";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                SqlDataReader dr = cmd.ExecuteReader();

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
                                    list.Add((string)dr.GetValue(i));
                                }
                            }
                        }
                    }
                    while (dr.NextResult());
                }
                sqlconnection.closeDatabase();//关闭数据库
            }


            {//显示某部影片的详细信息
                string sqlyuju = null;
                sqlconnection.openDatabase();//打开数据库

                //LinkButton alter = (LinkButton)sender;
                string movieName = Request.QueryString["content"];
                sqlyuju = "Select * from Movies" + " where MovieName= '" + movieName + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                SqlDataReader dr = cmd.ExecuteReader();
           
                Entity.Movies movie = new Entity.Movies();

                if (dr.Read())
                {
                    movie.setMovieNo((string)dr[0].ToString().Trim());
                    movie.setMovieName((string)dr[1].ToString().Trim());
                    movie.setType((string)dr[2].ToString().Trim());
                    movie.setCountry((string)dr[3].ToString().Trim());
                    movie.setMinute((string)dr[4].ToString().Trim());
                    movie.setDirector((string)dr[5].ToString().Trim());
                    movie.setActors((string)dr[6].ToString().Trim());
                    movie.setPlayDate((string)dr[7].ToString().Trim());
                    movie.setPrice((string)dr[8].ToString().Trim());
                    movie.setSummary((string)dr[9].ToString().Trim());
                    movie.setBriefIntroduction((string)dr[10].ToString().Trim());
                    movie.setImageMain((string)dr[11].ToString().Trim());
                    movie.setImage1((string)dr[12].ToString().Trim());
                    movie.setImage2((string)dr[13].ToString().Trim());
                    movie.setImage3((string)dr[14].ToString().Trim());
                    movie.setImage4((string)dr[15].ToString().Trim());
                    movie.setImage5((string)dr[16].ToString().Trim());
                    movie.setImage6((string)dr[17].ToString().Trim());

                    Session["Movie"] = movie; //保存movie对象
                    //Response.Redirect("/movieDetail.aspx");
                }
                
                mov = (Entity.Movies)Session["Movie"];
                
                sqlconnection.closeDatabase();//关闭数据库
            }
        }
    }
}