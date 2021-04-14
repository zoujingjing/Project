using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinemaTicketingSystem
{
    public partial class selectSeats : System.Web.UI.Page
    {
        protected string seat = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            seat = Request.QueryString["content"];
            if (seat == null)
            {
                Session["movieName"] = Request.QueryString["movie"];
                Session["playingDate"] = Request.QueryString["date"];
                Session["time"] = Request.QueryString["time"];
                Session["hallName"] = Request.QueryString["hall"];
                Session["price"] = Request.QueryString["price"];
            }
            Session["seat"] = seat;

        }
    }
}