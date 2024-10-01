using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class UserRepo
    {
        MakeMeUpEntities1 db = DatabaseSingleton.getInstance();
        public void UpdateById(int id, string username, string email, string gender, DateTime datetime)
        {
            User newUser = GetById(id);
            newUser.Username = username;
            newUser.UserEmail = email;
            newUser.UserGender = gender;
            newUser.UserDOB = datetime;
            db.SaveChanges();
        }
        public void InsertUser(int id, string name, string email, DateTime datetime, string password, string role, string gender)
        {
            User newUser = UserFactory.GenerateUser(id, name, email, datetime, password, role, gender);
            db.Users.Add(newUser);
            db.SaveChanges();
        }
        public void UpdatePassword(int id, string password)
        {
            User user = GetById(id);
            user.UserPassword = password;
            db.SaveChanges();
        }
        public User GetLastUser()
        {
            return db.Users.ToList().LastOrDefault();
        }
        public User SameUserName(string username)
        {
            return (from x in db.Users where x.Username == username select x).FirstOrDefault();
        }
        public List<User> GetUser()
        {
            return db.Users.ToList();
        }
        public User GetById(int id)
        {
            return (from x in db.Users where x.UserID == id select x).FirstOrDefault();
        }
        public User UserLogin(string name, string password)
        {
            return (from x in db.Users where x.Username.Equals(name) && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }
        
    }
}