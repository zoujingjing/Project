using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaTicketingSystem.Entity
{
    public class Users
    {
        private string name;
        private string password;
        private string email;
        private string phone;
        private string sex;
        private string username;
        private string paypsw;

        public string getPaypsw()
        {
            return paypsw;
        }
        public void setPaypsw(string paypsw)
        {
            this.paypsw = paypsw;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPhone()
        {
            return phone;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public string getSex()
        {
            return sex;
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }

        public string getUsername()
        {
            return username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
    }
}