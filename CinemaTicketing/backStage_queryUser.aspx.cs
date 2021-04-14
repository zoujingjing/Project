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
    public partial class backStage_queryUser : System.Web.UI.Page
    {
        protected List<Users> list = new List<Users>();  //创建一个列表用来存放需要显示的用户信息
        protected List<Users> queryList = new List<Users>();  //创建一个列表用来存放查找到的用户信息
        SQLConnection sqlconnection = new SQLConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            list = (List<Users>)Session["list"];//获取backStage_userManagement得到的结果
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //获取前台网页所提交的数据
            string message = Request.Form["TextBox1"];

            //显示用户列表
            for (int i = 0; i < list.Count(); i++)
            {
                //根据查询信息查询与该信息匹配的任意字段的所属用户的所有信息

                if (list[i].getName().Equals(message) || list[i].getSex().Equals(message) || list[i].getEmail().Equals(message) || list[i].getPhone().Equals(message) || list[i].getUsername().Equals(message))
                {
                    queryList.Add(list[i]);//将此Users对象添加到list中
                }


            }
            Session["list"] = queryList;
            Response.Redirect("/backStage_queryUser.aspx");
        }
    }
}