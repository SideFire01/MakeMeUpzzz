using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class InsertMakeupTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InsertMakeupTypeView.Visible = false;

            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                User currentUser;
                if (Session["user_session"] == null)
                {
                    int userID = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    currentUser = UserController.FindUser(userID);
                    Session["user_session"] = currentUser;
                }
                else
                {
                    currentUser = (User)Session["user_session"];
                }

                if (currentUser != null && currentUser.UserRole == "Admin")
                {
                    InsertMakeupTypeView.Visible = true;
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void InsertMakeupTypeBtn_Click(object sender, EventArgs e)
        {
            int makeupTypeID = MakeupController.generateMakeupTypeID();
            string makeupName = MakeupTypeNameTB.Text;

            string errorMessage = MakeupController.MakeupTypeValidator(makeupName);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                ErrorLbl.Text = errorMessage;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MakeupController.InsertMakeupType(makeupTypeID, makeupName);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}
