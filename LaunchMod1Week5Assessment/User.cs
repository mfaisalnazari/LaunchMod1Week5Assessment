﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMod1Week5Assessment
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
        }

        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public void CreatePassword(string email, string password)
        {
            if (email == Email)
            {
                Password = password;
            }

            
        }
        /*seperated the second if statement to return 
         confirmation of password creation*/
        public string Confirmation()
        { var confirmation = ("");
            if (Password != null)
            {
                confirmation = "Password Created";
            }
            return confirmation;        
        }

        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}
