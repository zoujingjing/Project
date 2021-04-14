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
    public partial class userRegister : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        protected string message = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected bool isNumberic(string message, out int result)
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
            string sqlyuju = null;

            //获取前台网页所提交的数据
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string phonenum = Request.Form["phoneNo"];
            string username = Request.Form["userName"];
            string password = Request.Form["password"];
            string repassword = Request.Form["pswRepeat"];
            string payPassword = Request.Form["payPassword"];
            string rePayPassword = Request.Form["rePayPassword"];
            int result = -1;

            //Session["email"] = this.email.Text;
            if (name == "" || email == "" || phonenum == "" || username == "" || password == "" || repassword == "" || payPassword == "" ||rePayPassword == "")
            {
                message = "请完善个人信息！";
            }
            else if (!password.Equals(repassword))
            {
                message = "登录密码输入不一致，请重新输入！";
            }
            else if (payPassword.Length != 6 || !(isNumberic(payPassword, out result)))
            {
                message = "支付密码必须为6位数字!";
                if (!payPassword.Equals(rePayPassword))
                {
                    message = "支付密码输入不一致，请重新输入！";
                }
            }
            else
            {
                try
                {
                    sqlconnection.openDatabase();//打开数据库
                    sqlyuju = "insert into UserManagement(Name,Email,Phone,Username,Password,PayPassword) values('" + name + "','" + email + "','" + phonenum + "','" + username + "','" + password  + "','" + payPassword + "')";
                    SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
                    
                    cmd.ExecuteNonQuery();
                    
                    sqlconnection.closeDatabase();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                Response.Write("<script>alert('注册成功!');window.location.href ='login.aspx'</script>");
            }
        }
    }
}