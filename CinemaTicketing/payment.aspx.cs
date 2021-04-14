using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinemaTicketingSystem
{
    public partial class payment : System.Web.UI.Page
    {
        protected string movieName;
        protected string playingDate;
        protected string time;
        protected string hallName;
        protected string price;
        protected string seat;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            movieName = (string)Session["movieName"];
            playingDate = (string)Session["playingDate"];
            time = (string)Session["time"];
            hallName = (string)Session["hallName"];
            price = (string)Session["price"];
            seat = (string)Session["seat"];
            
        }
    }
}