using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class RegistrationController
    {
        public string CheckGender(bool female, bool male)
        {
            return male ? "Male" : "Female";
        }
        public void Register(string username, string useremail, DateTime userdob, string userpassword, string userrole, string usergender)
        {
            UserHandler userhandle = new UserHandler();
            userhandle.InsertUser(username, useremail, userdob, userpassword, userrole, usergender);
        }
        public string RegistrationValidator(string username, string password, string confirmpass, string email, DateTime dateOfBirth, bool maleChecked, bool femaleChecked)
        {
            UserHandler userhandler = new UserHandler();
            User user = userhandler.GetByUsername(username);
            string errorMessage = "";

            if (string.IsNullOrEmpty(username))
            {
                errorMessage = "Username can't be empty!!";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                errorMessage = "Username must be 5-15 characters long!!";
            }
            else if (string.IsNullOrEmpty(password))
            {
                errorMessage = "Password can't be empty!!";
            }
            else if (string.IsNullOrEmpty(confirmpass))
            {
                errorMessage = "Confirmation password can't be empty";
            }
            else if (user != null)
            {
                errorMessage = "Username is already taken!!";
            }
            else if (string.IsNullOrEmpty(email))
            {
                errorMessage = "Email can't be empty!!";
            }
            else if (!password.Equals(confirmpass))
            {
                errorMessage = "Retyped password is not the same as original password!!";
            }
            else if (dateOfBirth == DateTime.MinValue)
            {
                errorMessage = "Date of birth can't be empty";
            }
            else if (!maleChecked && !femaleChecked)
            {
                errorMessage = "Please pick a gender already!!";
            }
            else if (!email.EndsWith("@gmail.com"))
            {
                errorMessage = "Email must end with @gmail.com";
            }
            return errorMessage;
        }
        
        
    }
}