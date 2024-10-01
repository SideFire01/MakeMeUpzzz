using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class LoginController
    {
        public User GetByUsername(string username)
        {
            UserHandler userhandle = new UserHandler();
            return userhandle.GetByUsername(username);
        }

        public string LoginValidator(string username, string password)
        {
            UserHandler userhandle = new UserHandler();
            User user = userhandle.GetByUsername(username);
            string errorMessage = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorMessage = "Please fill all fields properly!!";
            }
            else if (user == null)
            {
                errorMessage = "The user does not exist!!";
            }
            else if (user.UserPassword != password)
            {
                errorMessage = "Wrong password, try again!!";
            }

            return errorMessage;
        }
        
    }
}