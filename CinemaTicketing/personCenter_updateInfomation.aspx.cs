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
    public partial class personCenter_updateInfomation : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string old_username;
        protected string old_name;
        protected string old_sex;
        protected string old_email;
        protected string old_phone;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            old_email = (string)Session["email"];
            string sqlyuju = "select * from UserManagement where Email = '" + old_email + "'";
            sqlconnection.openDatabase();
            SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                old_name = (string)dr[0].ToString().Trim();
                old_sex = (string)dr[1].ToString().Trim();
                old_email = (string)dr[2].ToString().Trim();
                old_phone = (string)dr[3].ToString().Trim();
                old_username = (string)dr[4].ToString().Trim();
            }
        }

        protected void 提交_Click(object sender, EventArgs e)
        {
            string sqlyuju = null;
            old_email = (string)Session["email"];//获取前台网页所提交的数据

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
                sqlyuju = "update UserManagement set Name='" + name + "', Sex='" + sex + "',Email = '" + email + "',Username='" + username + "',Phone='" + phone + "' where Email='" + old_email + "';";
                SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                cmd.ExecuteNonQuery();
                sqlconnection.closeDatabase();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Session["username"] = username;

            Response.Write("<script>alert('修改成功!');window.location.href ='personCenter_main.aspx'</script>");//返回个人信息页面，显示更新后的信息
        }
        
    }
}