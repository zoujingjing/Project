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
    public partial class homePage2 : System.Web.UI.Page
    {
        
        protected string username;
        protected List<Entity.Movies> movieList = new List<Entity.Movies>();  //创建一个列表用来存放电影类

        protected void Page_Load(object sender, EventArgs e)
        {
            //在首页上显示登录人的用户名
            SQLConnection sqlconnection = new SQLConnection();
            string email = (string)Session["email"];//获取前台网页所提交的数据
            string sqlyuju = null;
   
            try
            {
                sqlconnection.openDatabase();//打开数据库
                sqlyuju = "SELECT Username FROM UserManagement WHERE Email = '" + email + "'";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器对象
                if (sdr.Read())
                {
                    username = sdr[0].ToString().Trim();
                    Session["username"] = username;
                }

                sdr.Close();
                sqlconnection.closeDatabase();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            //显示首页上的电影信息,数据库存储的前6行电影信息
            sqlyuju = "SELECT TOP 6* FROM Movies";
            sqlconnection.openDatabase();//打开数据库
            SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) 
            {
                Entity.Movies movie = new Entity.Movies();
                movie.setMovieName(dataSet.Tables[0].Rows[i][1].ToString().Trim());
                movie.setDirector(dataSet.Tables[0].Rows[i][5].ToString().Trim());
                movie.setActors(dataSet.Tables[0].Rows[i][6].ToString().Trim());
                movie.setType(dataSet.Tables[0].Rows[i][2].ToString().Trim());
                movie.setCountry(dataSet.Tables[0].Rows[i][3].ToString().Trim());
                movie.setPlayDate(dataSet.Tables[0].Rows[i][7].ToString().Trim());
                movie.setSummary(dataSet.Tables[0].Rows[i][9].ToString().Trim());
                movie.setImageMain(dataSet.Tables[0].Rows[i][11].ToString().Trim());

                movieList.Add(movie);
            }

            sqlconnection.closeDatabase();
            
        }
    }
    
}