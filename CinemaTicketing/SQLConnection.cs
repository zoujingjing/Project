using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CinemaTicketingSystem
{
    public class SQLConnection
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null; 
        string sqlyuju = null;

        //打开数据库
        public void openDatabase()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CinemaDB;Integrated Security=True";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    //Response.Write("<script>alert('成功建立链接!');</script>"); 
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //执行SQL语句
        public SqlCommand executeSQL(string sqlyuju)
        {
            try
            {
                cmd = new SqlCommand(sqlyuju, conn);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cmd;
          
        }

        //关闭数据库
        public void closeDatabase()
        {
            try 
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}