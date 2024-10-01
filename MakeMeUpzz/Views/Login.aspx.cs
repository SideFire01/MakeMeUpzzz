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
    public partial class Login : System.Web.UI.Page
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
                string userIDString = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(userIDString, out int userID))
                {
                    currentUser = UserController.FindUser(userID);
                    Session["user_session"] = currentUser;
                    Response.Redirect("~/Views/HomePage.aspx");
                    return;
                }
            }
        }

        protected void SubmitLogin_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            string username = usernameLogin.Text;
            string password = passwordLogin.Text;
            bool rememberMe = rememberMeLogin.Checked;

            string errorMessage = loginController.LoginValidator(username, password);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorLabel.Text = errorMessage;
                errorLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                User user = loginController.GetByUsername(username);
                Session["user_session"] = user;
                if (rememberMe)
                {
                    HttpCookie userCookie = new HttpCookie("user_cookie")
                    {
                        Value = user.UserID.ToString(),
                        Expires = DateTime.Now.AddHours(12)
                    };
                    Response.Cookies.Add(userCookie);
                }
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void RegisterPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }
    }
}
