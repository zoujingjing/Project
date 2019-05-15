using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaTicketingSystem.Entity
{
    public class MovieSession
    {
        private string movieNo;
        private string movieName;
        private string type;
        private string price;
        private string playingDate;
        private string time;
        private string hallName;
        private string hallType;


        public string getMovieNo()
        {
            return movieNo;
        }
        public void setMovieNo(string movieno)
        {
            this.movieNo = movieno;
        }
        public string getMovieName()
        {
            return movieName;
        }
        public void setMovieName(string name)
        {
            this.movieName = name;
        }
        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getPrice()
        {
            return price;
        }
        public void setPrice(string price)
        {
            this.price = price;
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
        public string getHallType()
        {
            return hallType;
        }
        public void setHallType(string hallType)
        {
            this.hallType = hallType;
        }
    }
}