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
    public partial class movieList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        SqlConnection conn = null;
        SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  
        string sqlyuju = null;

        protected void Button1_Click(object sender, EventArgs e)
        {
            //获取前台网页所提交的数据
            string movieName = Request.Form["TextBox1"];
            string tip;
            Session["message"] = null; 

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CinemaDB;Integrated Security=True";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    //Response.Write("<script>alert('成功建立链接!');</script>"); 
                }
                sqlyuju = "Select * from Movies" + " where MovieName= '" + movieName + "'";
                cmd = new SqlCommand(sqlyuju, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Session["movieName"] = (string)dr[1].ToString().Trim();
                    Session["type"] = (string)dr[2].ToString().Trim();
                    Session["country"] = (string)dr[3].ToString().Trim();
                    Session["director"] = (string)dr[4].ToString().Trim();
                    Session["actors"] = (string)dr[5].ToString().Trim();
                    Session["playTime"] = (string)dr[6].ToString().Trim();
                    Session["price"] = (string)dr[7].ToString().Trim();
                    Response.Redirect("/queryMovie.aspx");
                }
                else
                {
                    tip = "没有查找到有关该影片信息";
                    Session["message"] = tip;
                    Response.Write("<script>alert('没有查找到有关该影片信息');</script>");
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}