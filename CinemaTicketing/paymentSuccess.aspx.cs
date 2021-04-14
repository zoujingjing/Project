using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinemaTicketingSystem
{
    public partial class paymentSuccess : System.Web.UI.Page
    {
        protected string orderNo;
        protected string movieName;
        protected string customerName;
        protected string playingDate;
        protected string time;
        protected string hallName;
        protected string seat;
        protected string price;
        protected string statement;
        protected string generateDate;

        protected void Page_Load(object sender, EventArgs e)
        {

            //显示订单信息
            orderNo = (string)Session["orderNo"];
            movieName = (string)Session["movieName"];
            customerName = (string)Session["customerName"];
            playingDate = (string)Session["playingDate"];
            time = (string)Session["time"];
            hallName = (string)Session["hallName"];
            seat = (string)Session["seat"];
            price = (string)Session["price"];
            statement = "未完成";
            generateDate = (string)Session["generateDate"];
            
        }
    }
}