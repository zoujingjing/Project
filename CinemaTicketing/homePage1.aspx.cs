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
    public partial class homePage1 : System.Web.UI.Page
    {
        protected List<Entity.Movies> movieList = new List<Entity.Movies>();  //创建一个列表用来存放电影类
        
        protected void Page_Load(object sender, EventArgs e)
        {
            SQLConnection sqlconnection = new SQLConnection();
            string sqlyuju = null;
            
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