using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        public List<User> Users { get; private set; } = null;

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
                string cookieValue = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(cookieValue, out int userId))
                {
                    currentUser = UserController.FindUser(userId);
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

            if (currentUser.UserRole == "Admin" && !IsPostBack)
            {
                Users = UserController.GetUsers();
                UserData.DataSource = Users;
                UserData.DataBind();
            }
        }

        protected void UserData_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

}
