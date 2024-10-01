using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;

namespace MakeMeUpzz.Handlers
{
    public class UserHandler
    {
        private readonly UserRepo _userRepo;

        public UserHandler()
        {
            _userRepo = new UserRepo();
        }
        public int GenerateID()
        {
            UserHandler uhan = new UserHandler();
            User user = uhan.GetLastUser();
            if (user == null)
            {
                return 1;
            }
            int id = user.UserID;
            id++;
            return id;
        }
        public User Login(string username, string password)
        {
            return _userRepo.UserLogin(username, password);
        }

        public void InsertUser( string username, string useremail, DateTime userdob, string userpassword, string userrole, string usergender)
        {
            int userid = GenerateID();
            _userRepo.InsertUser(userid, username, useremail, userdob, userpassword, userrole, usergender);
        }

        public User GetLastUser()
        {
            return _userRepo.GetLastUser();
        }

        public User GetByUsername(string username)
        {
            return _userRepo.SameUserName(username);
        }

        public List<User> GetUsers()
        {
            return _userRepo.GetUser();
        }

        public User GetById(int id)
        {
            return _userRepo.GetById(id);
        }

        public void UpdateProfile(int id, string username, string email, string gender, DateTime dob)
        {
            _userRepo.UpdateById(id, username, email, gender, dob);
        }

        public void UpdatePassword(int id, string password)
        {
            _userRepo.UpdatePassword(id, password);
        }
    }
}
