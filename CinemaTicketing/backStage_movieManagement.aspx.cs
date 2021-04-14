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
    public partial class backStage_movieManagement : System.Web.UI.Page
    {
        protected List<Movies> moviesList = new List<Movies>();
        protected Movies queryMovie = new Movies();
        SQLConnection sqlconnection = new SQLConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            sqlconnection.openDatabase();
            string sqlyuju1 = "select * from Movies";
            SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Movies movie = new Movies();
                movie.setMovieNo(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                movie.setMovieName(dataSet.Tables[0].Rows[i][1].ToString().Trim());
                movie.setType(dataSet.Tables[0].Rows[i][2].ToString().Trim());
                movie.setCountry(dataSet.Tables[0].Rows[i][3].ToString().Trim());
                movie.setMinute(dataSet.Tables[0].Rows[i][4].ToString().Trim());
                movie.setDirector(dataSet.Tables[0].Rows[i][5].ToString().Trim());
                movie.setActors(dataSet.Tables[0].Rows[i][6].ToString().Trim());
                movie.setPlayDate(dataSet.Tables[0].Rows[i][7].ToString().Trim());
                movie.setPrice(dataSet.Tables[0].Rows[i][8].ToString().Trim());
                movie.setSummary(dataSet.Tables[0].Rows[i][9].ToString().Trim());
                movie.setBriefIntroduction(dataSet.Tables[0].Rows[i][10].ToString().Trim());
                movie.setImageMain(dataSet.Tables[0].Rows[i][11].ToString().Trim());
                movie.setImage1(dataSet.Tables[0].Rows[i][12].ToString().Trim());
                movie.setImage2(dataSet.Tables[0].Rows[i][13].ToString().Trim());
                movie.setImage3(dataSet.Tables[0].Rows[i][14].ToString().Trim());
                movie.setImage4(dataSet.Tables[0].Rows[i][15].ToString().Trim());
                movie.setImage5(dataSet.Tables[0].Rows[i][16].ToString().Trim());
                movie.setImage6(dataSet.Tables[0].Rows[i][17].ToString().Trim());

                moviesList.Add(movie);
                sqlconnection.closeDatabase();
            }


            //点击删除按钮时
            string deleteMovieNo = Request.QueryString["deleteMovieNo"];
            Session["deleteMovieNo"] = deleteMovieNo;
            if (deleteMovieNo != null) 
            {
                Session["request"] = "backStage_movieManagement";
                string strMsg = "确定要删除吗？";
                Response.Write("<Script Language='JavaScript'>if ( window.confirm('" + strMsg + "')) {alert('删除成功!');window.location.href ='executeDeleteSql.aspx'} else {history.back();};</script>");

                //Response.Write("<script>alert('删除成功!');window.location.href ='backStage_movieManagement.aspx'</script>");
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

            string queryType = Request.Form["queryType"];
            sqlconnection.openDatabase();

            if (queryType.Equals("影片编号")) 
            {
                string movieNo = Request.Form["TextBox1"];
                int result = -1;
                if (isNumberic(movieNo, result))
                {
                    string sqlyuju2 = "Select * from Movies" + " where MovieNo= '" + movieNo + "'";
                    SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        queryMovie.setMovieNo((string)dr2[0].ToString().Trim());
                        queryMovie.setMovieName((string)dr2[1].ToString().Trim());
                        queryMovie.setType((string)dr2[2].ToString().Trim());
                        queryMovie.setCountry((string)dr2[3].ToString().Trim());
                        queryMovie.setMinute((string)dr2[4].ToString().Trim());
                        queryMovie.setDirector((string)dr2[5].ToString().Trim());
                        queryMovie.setActors((string)dr2[6].ToString().Trim());
                        queryMovie.setPlayDate((string)dr2[7].ToString().Trim());
                        queryMovie.setPrice((string)dr2[8].ToString().Trim());
                        queryMovie.setSummary((string)dr2[9].ToString().Trim());
                        queryMovie.setBriefIntroduction((string)dr2[10].ToString().Trim());
                        queryMovie.setImageMain((string)dr2[11].ToString().Trim());
                        queryMovie.setImage1((string)dr2[12].ToString().Trim());
                        queryMovie.setImage2((string)dr2[13].ToString().Trim());
                        queryMovie.setImage3((string)dr2[14].ToString().Trim());
                        queryMovie.setImage4((string)dr2[15].ToString().Trim());
                        queryMovie.setImage5((string)dr2[16].ToString().Trim());
                        queryMovie.setImage6((string)dr2[17].ToString().Trim());

                        Session["queryMovie"] = queryMovie;
                        Response.Redirect("/backStage_queryMovie.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('抱歉，没有查找到有关该影片信息！');</script>");
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
                    string sqlyuju3 = "Select * from Movies" + " where MovieName= '" + movieName + "'";
                    SqlCommand cmd3 = sqlconnection.executeSQL(sqlyuju3);
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        queryMovie.setMovieNo((string)dr3[0].ToString().Trim());
                        queryMovie.setMovieName((string)dr3[1].ToString().Trim());
                        queryMovie.setType((string)dr3[2].ToString().Trim());
                        queryMovie.setCountry((string)dr3[3].ToString().Trim());
                        queryMovie.setMinute((string)dr3[4].ToString().Trim());
                        queryMovie.setDirector((string)dr3[5].ToString().Trim());
                        queryMovie.setActors((string)dr3[6].ToString().Trim());
                        queryMovie.setPlayDate((string)dr3[7].ToString().Trim());
                        queryMovie.setPrice((string)dr3[8].ToString().Trim());
                        queryMovie.setSummary((string)dr3[9].ToString().Trim());
                        queryMovie.setBriefIntroduction((string)dr3[10].ToString().Trim());
                        queryMovie.setImageMain((string)dr3[11].ToString().Trim());
                        queryMovie.setImage1((string)dr3[12].ToString().Trim());
                        queryMovie.setImage2((string)dr3[13].ToString().Trim());
                        queryMovie.setImage3((string)dr3[14].ToString().Trim());
                        queryMovie.setImage4((string)dr3[15].ToString().Trim());
                        queryMovie.setImage5((string)dr3[16].ToString().Trim());
                        queryMovie.setImage6((string)dr3[17].ToString().Trim());

                        Session["queryMovie"] = queryMovie;
                        Response.Redirect("/backStage_queryMovie.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('抱歉，没有查找到有关该影片信息！');</script>");
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