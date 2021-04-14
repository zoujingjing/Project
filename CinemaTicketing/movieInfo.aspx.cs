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
    public partial class movieInfo : System.Web.UI.Page
    {
        protected List<string> list = new List<string>();  //创建一个列表用来存放电影名称
        SQLConnection sqlconnection = new SQLConnection();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlyuju = null;
            sqlconnection.openDatabase();//打开数据库
            
            sqlyuju = "select MovieName from Movies";
            SqlCommand cmd = sqlconnection.executeSQL(sqlyuju);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                //读取多个结果集
                //用do--while方法，do中先读取第一个结果集，while中读取第二个结果集，依次循环
                do
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                
                                list.Add((string)dr.GetValue(i));
                            }
                        }
                    }
                }
                while (dr.NextResult());
            }
            sqlconnection.closeDatabase();//关闭数据库
        }

        
    }
}