using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UserController
    {
        public static List<User> GetUsers()
        {
            UserHandler userHandler = new UserHandler();
            return userHandler.GetUsers();
        }
        public static User FindUser(int id)
        {
            UserHandler userHandler = new UserHandler();
            return userHandler.GetById(id);
        }
        
    }
}