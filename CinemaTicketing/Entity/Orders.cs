using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaTicketingSystem.Entity
{
    public class Orders
    {
        private string orderNo;
        private string movieName;
        private string customerName;
        private string playingDate;
        private string time;
        private string hallName;
        private string seat;
        private string price;
        private string statement;
        private string generateDate;


        public string getOrderNo()
        {
            return orderNo;
        }
        public void setOrderNo(string orderNo)
        {
            this.orderNo = orderNo;
        }

        public string getMovieName()
        {
            return movieName;
        }
        public void setMovieName(string name)
        {
            this.movieName = name;
        }

        public string getCustomerName()
        {
            return customerName;
        }
        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string getPlayingDate()
        {
            return playingDate;
        }
        public void setPlayingDate(string playingDate)
        {
            this.playingDate = playingDate;
        }

        public string getTime()
        {
            return time;
        }
        public void setTime(string time)
        {
            this.time = time;
        }

        public string getHallName()
        {
            return hallName;
        }
        public void setHallName(string hallName)
        {
            this.hallName = hallName;
        }

        public string getSeat()
        {
            return seat;
        }
        public void setSeat(string seat)
        {
            this.seat = seat;
        }

        public string getPrice()
        {
            return price;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getStatement()
        {
            return statement;
        }
        public void setStatement(string statement)
        {
            this.statement = statement;
        }

        public string getGenerateDate()
        {
            return generateDate;
        }
        public void setGenerateDate(string generateDate)
        {
            this.generateDate = generateDate;
        }
        
    }
}