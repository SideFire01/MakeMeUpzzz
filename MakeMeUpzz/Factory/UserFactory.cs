using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class UserFactory
    {
        public static User GenerateUser(int id, string username, string email, DateTime datetime, string password, string role, string gender)
        {
            User newUser = new User();
            newUser.UserID = id;
            newUser.Username = username;
            newUser.UserPassword = password;
            newUser.UserGender = gender;
            newUser.UserEmail = email;
            newUser.UserDOB = datetime;
            newUser.UserRole = role;
            return newUser;
        }
    }
}