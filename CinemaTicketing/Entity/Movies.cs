using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaTicketingSystem.Entity
{
    public class Movies
    {
        private string movieNo;
        private string movieName;
        private string type;
        private string country;
        private string minute;
        private string director;
        private string actors;
        private string playDate;
        private string price;
        private string summary;
        private string briefIntroduction;
        private string imageMain;
        private string image1;
        private string image2;
        private string image3;
        private string image4;
        private string image5;
        private string image6;


        public string getMovieNo()
        {
            return movieNo;
        }
        public void setMovieNo(string movieNo)
        {
            this.movieNo = movieNo;
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
        public string getCountry()
        {
            return country;
        }
        public void setCountry(string country)
        {
            this.country = country;
        }
        public string getMinute()
        {
            return minute;
        }
        public void setMinute(string minute)
        {
            this.minute = minute;
        }
        public string getDirector()
        {
            return director;
        }
        public void setDirector(string director)
        {
            this.director = director;
        }
        public string getActors()
        {
            return actors;
        }
        public void setActors(string actors)
        {
            this.actors = actors;
        }
        public string getPlayDate()
        {
            return playDate;
        }
        public void setPlayDate(string playDate)
        {
            this.playDate = playDate;
        }
        public string getPrice()
        {
            return price;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }
        public string getSummary()
        {
            return summary;
        }
        public void setSummary(string summary)
        {
            this.summary = summary;
        }
        public string getBriefIntroduction()
        {
            return briefIntroduction;
        }
        public void setBriefIntroduction(string briefIntroduction)
        {
            this.briefIntroduction = briefIntroduction;
        }

        public string getImageMain()
        {
            return imageMain;
        }
        public void setImageMain(string imageMain)
        {
            this.imageMain = imageMain;
        }

        public string getImage1()
        {
            return image1;
        }
        public void setImage1(string image1)
        {
            this.image1 = image1;
        }
        public string getImage2()
        {
            return image2;
        }
        public void setImage2(string image2)
        {
            this.image2 = image2;
        }
        public string getImage3()
        {
            return image3;
        }
        public void setImage3(string image3)
        {
            this.image3 = image3;
        }
        public string getImage4()
        {
            return image4;
        }
        public void setImage4(string image4)
        {
            this.image4 = image4;
        }
        public string getImage5()
        {
            return image5;
        }
        public void setImage5(string image5)
        {
            this.image5 = image5;
        }
        public string getImage6()
        {
            return image6;
        }
        public void setImage6(string image6)
        {
            this.image6 = image6;
        }

    }
}