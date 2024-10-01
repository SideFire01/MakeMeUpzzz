using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentUser = null;

            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
                return;
            }

            if (Session["user_session"] == null)
            {
                string cookieId = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(cookieId, out int nid))
                {
                    currentUser = UserController.FindUser(nid);
                    Session["user_session"] = currentUser;
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                    return;
                }
            }
            else
            {
                currentUser = Session["user_session"] as User;
            }

            ProfileController profileController = new ProfileController();
            User sessionUser = Session["user_session"] as User;
            int userId = sessionUser.UserID;

            if (!IsPostBack)
            {
                User user = profileController.GetById(userId);

                if (user != null)
                {
                    usernameRegister.Text = user.Username;
                    emailRegister.Text = user.UserEmail;

                    if (user.UserGender == "Male")
                    {
                        male.Checked = true;
                    }
                    else if (user.UserGender == "Female")
                    {
                        female.Checked = true;
                    }

                    dobCalendar.SelectedDate = user.UserDOB;
                    dobCalendar.VisibleDate = user.UserDOB;
                }
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            string username = usernameRegister.Text;
            string email = emailRegister.Text;
            DateTime dateOfBirth = dobCalendar.SelectedDate;
            ProfileController profileController = new ProfileController();
            bool isMale = male.Checked;
            bool isFemale = female.Checked;
            string errorMessage = profileController.ProfileValidator(username, email, dateOfBirth, isMale, isFemale);
            string gender = profileController.GenderValidator(isMale, isFemale);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                updateerror.Text = errorMessage;
                updateerror.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                User sessionUser = Session["user_session"] as User;
                profileController.UpdateProfile(sessionUser, username, email, gender, dateOfBirth);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void UpdatePassword_Click(object sender, EventArgs e)
        {
            User sessionUser = Session["user_session"] as User;
            int userId = sessionUser.UserID;
            ProfileController profileController = new ProfileController();
            string currentPassword = passwordRegister.Text;
            string newPassword = newpasswordrupdate.Text;
            string errorMessage = profileController.PasswordValidator(sessionUser, currentPassword, newPassword);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                passerr.Text = errorMessage;
                passerr.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                profileController.UpdatePassword(userId, newPassword);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}
