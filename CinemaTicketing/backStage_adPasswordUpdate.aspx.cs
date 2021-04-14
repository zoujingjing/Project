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
    public partial class backStage_adPasswordUpdate : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string message = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlyuju = null;
            string id = (string)Session["id"];

            //获取前台网页所提交的数据
            string beforecode = Request.Form["beforecode"];
            string newcode = Request.Form["newcode"];
            string renewrode = Request.Form["renewrode"];

            if (newcode == "")//用户未输入新密码
            {
                message = "请输入新密码";
            }
            else if (!newcode.Equals(renewrode))//用户两次输入的新密码不一致
            {
                message = "两次新密码输入不一致，请重新输入";
            }
            else
            {
                try
                {
                    sqlconnection.openDatabase();//打开数据库
                    //根据用户名和输入的原密码查询是否有此记录，以核对输入的原密码是否正确
                    sqlyuju = "SELECT count(*) FROM Administrator WHERE Id = '" + id + "'and password = '" + beforecode + "'";
                    SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                    SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器对象
                    sdr.Read();
                    sdr.Close();
                    int n = (int)cmd.ExecuteScalar();//传回第一行，赋给n
                    if (n >= 1)//原密码输入正确
                    {
                        sqlyuju = "update Administrator set Password = '" + newcode + "' where Id = '" + id + "';";
                        SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju);
                        cmd2.ExecuteNonQuery();
                        Response.Write("<script>alert('修改成功!');window.location.href ='backStage_main.aspx'</script>");
                    }
                    else
                    {
                        message = "原密码错误,请重新输入";

                    }
                    sqlconnection.closeDatabase();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}