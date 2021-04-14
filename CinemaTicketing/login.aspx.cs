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
    public partial class login : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string message = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlyuju = null;

            //获取前台网页所提交的数据
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            Session["email"] = this.email.Text;
            if (email == "")
            {
                message = "用户名为空，请输入用户名！";

            }
            else if (password == "")
            {
                message = "密码为空，请输入密码！";
                
            }
            else
            {
                try
                {
                    sqlconnection.openDatabase();//打开数据库
                    sqlyuju = "SELECT count(*) FROM UserManagement WHERE Email = '" + email + "'and Password = '" + password + "'";
                    SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                    SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器对象
                    sdr.Read();
                    sdr.Close();
                    int n = (int)cmd.ExecuteScalar();//传回第一行，赋给n
                    if (n >= 1)
                    {
                        Response.Redirect("/homePage2.aspx");
                    }
                    else
                    {
                        message = "用户名或密码错误！请重新输入";

                    }
                    sqlconnection.closeDatabase();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/userRegister.aspx");
        }
    }
}