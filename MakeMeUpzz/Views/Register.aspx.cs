using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentUser = null;

           
            if (Session["user_session"] != null && Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
                return;
            }

           
            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                return;
            }

            
            if (Session["user_session"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
                return;
            }

            
            if (Session["user_session"] == null)
            {
                string cookieId = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(cookieId, out int userId))
                {
                    currentUser = UserController.FindUser(userId);
                    Session["user_session"] = currentUser;
                    Response.Redirect("~/Views/HomePage.aspx");
                    return;
                }
            }
        }

        protected void SubmitRegister_Click(object sender, EventArgs e)
        {
            RegistrationController registrationController = new RegistrationController();

           
            string username = usernameRegister.Text;
            string password = passwordRegister.Text;
            string confirmPassword = confirmPasswordRegister.Text;
            string email = emailRegister.Text;
            DateTime dateOfBirth = dobCalendar.SelectedDate;
            bool isMale = male.Checked;
            bool isFemale = female.Checked;
            string role = "User";

           
            string errorMessage = registrationController.RegistrationValidator(username, password, confirmPassword, email, dateOfBirth, isMale, isFemale);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                registerError.Text = errorMessage;
                registerError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
               
                string gender = registrationController.CheckGender(isMale, isFemale);

             
                registrationController.Register(username, email, dateOfBirth, password, role, gender);
                Response.Redirect("~/Views/Login.aspx");
            }
        }

        protected void LoginPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}
