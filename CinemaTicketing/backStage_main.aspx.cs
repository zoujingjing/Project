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
    public partial class backStage_main : System.Web.UI.Page
    {
        SQLConnection sqlconnection = new SQLConnection();
        //定义前台所需显示的字段，赋初值为空
        protected String id = null;
        protected String name = null;
        protected String sex = null;
        protected String email = null;
        protected String phone = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            String sqlyuju = null;
            Session["yeshuTime"] = 1;
            sqlconnection.openDatabase();//打开数据库
            id = (string)Session["id"];//获取前台网页所提交的数据

            sqlyuju = "select * from administrator where Id =  '" + id + "'";//查询当前用户的所有信息
            SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())//读取查询到的记录
            {
                //从记录里取值，赋值给需显示的对应的字段
                id = (string)dr[0].ToString().Trim();
                Session["id"] = id;
                name = (string)dr[1].ToString().Trim();
                Session["name"] = name;
                sex = (string)dr[2].ToString().Trim();
                Session["sex"] = sex;
                email = (string)dr[3].ToString().Trim();
                Session["email"] = email;
                phone = (string)dr[4].ToString().Trim();
                Session["phone"] = phone;
               
            }

            sqlconnection.closeDatabase();//关闭数据库
        }
    }
}