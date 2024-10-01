using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ProfileController
    {
        public void UpdatePassword(int id, string password)
        {
            UserHandler uhan = new UserHandler();
            uhan.UpdatePassword(id, password);
        }
        public User GetById(int id)
        {
            UserHandler userhandle = new UserHandler();
            return userhandle.GetById(id);
        }
        public void UpdateProfile(User tempuser, string username, string email, string gender, DateTime dob)
        {
            int id = tempuser.UserID;
            UserHandler userhandle = new UserHandler();
            userhandle.UpdateProfile(id, username, email, gender, dob);
        }
        public string GenderValidator(bool male, bool female)
        {
            return male ? "Male" : "Female";
        }
        public string PasswordValidator(User user,string password, string newpassword) 
        {
            string errorMessage = "";
            string oldPassword = user.UserPassword;
            if (string.IsNullOrEmpty(password))
            {
                errorMessage = "Password can't be empty";
            }
            else if (string.IsNullOrEmpty(newpassword))
            {
                errorMessage = "Password can't bee empty";
            }
            else if (!password.Equals(oldPassword))
            {
                errorMessage = "New password does not match";
            }
            return errorMessage;
        }
        public string ProfileValidator(string username, string email, DateTime dateOfBirth, bool maleChecked, bool femaleChecked)
        {
            UserHandler userhandle = new UserHandler();
            User user = userhandle.GetByUsername(username);
            string errorMessage = "";

            if (string.IsNullOrEmpty(username))
            {
                errorMessage = "Username can't be empty!!";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                errorMessage = "Username must be 5-15 characters!!";
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorMessage = "Email can't be empty!!";
            }
            else if (!email.EndsWith("@gmail.com"))
            {
                errorMessage = "Email must end with @gmail.com";
            }
            else if (dateOfBirth == DateTime.MinValue)
            {
                errorMessage = "Date of birth can't be empty!!";
            }
            else if (!maleChecked && !femaleChecked)
            {
                errorMessage = "Please check the gender box";
            }

            return errorMessage;
        }

    }
}