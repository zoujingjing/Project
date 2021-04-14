using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using CinemaTicketingSystem.Entity;

namespace CinemaTicketingSystem
{
    public partial class backStage_userManagement : System.Web.UI.Page
    {
        protected List<string> userEmailList = new List<string>();  //创建一个列表用来存放所有用户的邮箱
        protected List<Users> list = new List<Users>();  //创建一个列表用来存放所有用户的信息
        protected List<Users> queryList = new List<Users>();  //创建一个列表用来存放查找到的用户信息
        SQLConnection sqlconnection = new SQLConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlconnection.openDatabase();//打开数据库
            //查询所有用户的邮箱，并存放在userEmailList里
            string sqlyuju1 = "select email from UserManagement";
            SqlCommand cmd1 = sqlconnection.executeSQL(sqlyuju1);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.HasRows)
            {
                //读取多个结果集
                //用do--while方法，do中先读取第一个结果集，while中读取第二个结果集，依次循环
                do
                {
                    if (dr1.HasRows)
                    {
                        while (dr1.Read())
                        {
                            for (int i = 0; i < dr1.FieldCount; i++)
                            {
                                userEmailList.Add((string)dr1.GetValue(i));//将读取到的某一条记录添加到userEmailList中
                            }
                        }
                    }
                }
                while (dr1.NextResult());
            }
            dr1.Close();
            sqlconnection.closeDatabase();//关闭数据库


            //根据userEmailList中的所有用户邮箱来查询出该用户的所有信息
            sqlconnection.openDatabase();//打开数据库
            for (int i = 0; i < userEmailList.Count(); i++)
            {
                //根据userIdList中的一项，读取某个用户的全部信息
                string sqlyuju2 = "Select * from UserManagement where email='" + userEmailList[i] + "'";
                SqlCommand cmd2 = sqlconnection.executeSQL(sqlyuju2);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    Users user = new Users();//创建一个新的User对象
                    //将读取到的数据赋值给新建Users对象
                    user.setName((string)dr2[0].ToString().Trim());
                    user.setSex((string)dr2[1].ToString().Trim());
                    user.setEmail(userEmailList[i]);
                    user.setPhone((string)dr2[3].ToString().Trim());
                    user.setUsername((string)dr2[4].ToString().Trim());

                    list.Add(user);//将此Users对象添加到list中
                }

                dr2.Close();
            }
            Session["list"] = list;
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            //获取前台网页所提交的数据
            string message = Request.Form["TextBox1"];

            //将查询到的用户添加到queryList中
            for (int i = 0; i < list.Count(); i++)
            {
                //根据查询信息查询与该信息匹配的任意字段的所属用户的所有信息
                if (list[i].getName().Equals(message) || list[i].getSex().Equals(message) || list[i].getEmail().Equals(message) || list[i].getPhone().Equals(message) || list[i].getUsername().Equals(message))
                {
                    queryList.Add(list[i]);//将此Users对象添加到list中
                }

            }
            Session["list"] = queryList;//传送给backStage_queryUser显示
            Response.Redirect("backStage_queryUser.aspx");
        }
    }
}