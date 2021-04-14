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
    public partial class personCenter_updatePassword : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string message1 = null;
        protected string message2 = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlyuju = null;
            string username = (string)Session["username"];

            //获取前台网页所提交的数据
            string beforecode = Request.Form["beforecode1"];
            string newcode = Request.Form["newcode1"];
            string renewrode = Request.Form["renewrode1"];

            if (newcode == "")//用户未输入新密码
            {
                message1 = "请输入新密码";
            }
            else if (!newcode.Equals(renewrode))//用户两次输入的新密码不一致
            {
                message1 = "两次新密码输入不一致，请重新输入";
            }
            else
            {
                try
                {
                    sqlconnection.openDatabase();//打开数据库
                    //根据用户名和输入的原密码查询是否有此记录，以核对输入的原密码是否正确
                    sqlyuju = "SELECT count(*) FROM UserManagement WHERE Username = '" + username + "'and Password = '" + beforecode + "'";
                    SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju);
                    SqlDataReader sdr = cmd1.ExecuteReader();//创建数据读取器对象
                    sdr.Read();
                    sdr.Close();
                    int n = (int)cmd1.ExecuteScalar();//传回第一行，赋给n
                    if (n >= 1)//原密码输入正确
                    {
                        sqlyuju = "update UserManagement set Password = '" + newcode + "' where username = '" + username + "';";
                        SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju);
                        cmd2.ExecuteNonQuery();
                        Response.Write("<script>alert('修改成功!');window.location.href ='personCenter_main.aspx'</script>");//返回个人信息页面
                    }
                    else
                    {
                        message1 = "原密码错误,请重新输入";

                    }
                    sqlconnection.closeDatabase();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            Session["username"] = username;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sqlyuju = null;
            string username = (string)Session["username"];//获取前台网页所提交的数据

            //获取前台网页所提交的数据
            string beforecode = Request.Form["beforecode2"];
            string newcode = Request.Form["newcode2"];
            string renewrode = Request.Form["renewrode2"];

            if (newcode == "")//用户未输入新密码
            {
                message2 = "请输入新密码";
            }
            else if (!newcode.Equals(renewrode))//用户两次输入的新密码不一致
            {
                message2 = "两次新密码输入不一致，请重新输入";
            }
            else
            {
                try
                {
                    sqlconnection.openDatabase();//打开数据库
                    //根据用户名和输入的原密码查询是否有此记录，以核对输入的原密码是否正确
                    sqlyuju = "SELECT count(*) FROM UserManagement WHERE Username = '" + username + "'and PayPassword = '" + beforecode + "'";
                    SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                    SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器对象
                    sdr.Read();
                    sdr.Close();
                    int n = (int)cmd.ExecuteScalar();//传回第一行，赋给n
                    if (n >= 1)//原密码输入正确
                    {
                        sqlyuju = "update UserManagement set PayPassword='" + newcode + "' where username = '" + username + "';";
                        SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju);
                        cmd2.ExecuteNonQuery();
                        Response.Write("<script>alert('修改成功!');window.location.href ='personCenter_main.aspx'</script>");//返回个人信息页面
                    }
                    else
                    {
                        message2 = "原密码错误,请重新输入";

                    }
                    sqlconnection.closeDatabase();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            Session["username"] = username;


        }
    }
}