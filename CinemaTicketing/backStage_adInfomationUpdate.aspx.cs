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
    public partial class backStage_adInfomationUpdate : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string old_id;
        protected string old_name;
        protected string old_sex;
        protected string old_email;
        protected string old_phone;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            old_id = (string)Session["id"];
            string sqlyuju = "select * from Administrator where Id = '" + old_id + "'";
            sqlconnection.openDatabase();
            SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                old_id = (string)dr[0].ToString().Trim();
                old_name = (string)dr[1].ToString().Trim();
                old_sex = (string)dr[2].ToString().Trim();
                old_email = (string)dr[3].ToString().Trim();
                old_phone = (string)dr[4].ToString().Trim();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlyuju = null;
            string id = (string)Session["id"];//获取前台网页所提交的数据

            //获取前台网页所提交的数据
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string sex = Request.Form["sex"];
            string phone = Request.Form["phone"];
            string username = Request.Form["username"];

            try
            {
                sqlconnection.openDatabase();//打开数据库
                //将获取到的数据更新到数据库中
                sqlyuju = "update Administrator set Name='" + name + "', Sex='" + sex + "',Email = '" + email + "',Phone='" + phone + "' where Id='" + id + "';";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                cmd.ExecuteNonQuery();
                sqlconnection.closeDatabase();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Response.Write("<script>alert('修改成功!');window.location.href ='backStage_main.aspx'</script>");//返回主页面，显示更新后的信息
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/backStage_adInfomationUpdate.aspx");//返回本页面，重新填写信息
        }

        
    }
}