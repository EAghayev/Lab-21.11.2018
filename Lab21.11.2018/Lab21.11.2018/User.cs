using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._11._2018
{
    class User:Human
    {
        public User(string name, string surname) : base(name, surname)
        {
            this.Loggined = false;
        }

        private string _username;
        public string Username
        {
            get
            {
                return this._username;
            }
        }
        private string _password;


        public void SignUp(string username,string password)
        {
            this._password = password;
            this._username = username;
        }
        public bool ConfirmPass(string pass)
        {
            if (this._password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ResetPass (string lastPass,string newPass)
        {
            if (ConfirmPass(lastPass))
            {
                this._password = newPass;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Loggined { get; set; }


    }
}
