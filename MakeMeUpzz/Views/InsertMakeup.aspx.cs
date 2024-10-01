using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Web.UI;

namespace MakeMeUpzz.Views
{
    public partial class InsertMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_session"] == null)
            {
                if (Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/Views/Login.aspx");
                    return;
                }

                string userCookieValue = Request.Cookies["user_cookie"].Value;
                if (int.TryParse(userCookieValue, out int userID))
                {
                    Session["user_session"] = UserController.FindUser(userID);
                }
                else
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                    return;
                }
            }

            User currentUser = (User)Session["user_session"];

            if (currentUser.UserRole == "User")
            {
                Response.Redirect("~/Views/HomePage.aspx");
                return;
            }
        }

        protected void InsertMakeupBtn_Click(object sender, EventArgs e)
        {
            string makeupName = MakeupNameTB.Text;
            int makeupPrice = int.Parse(MakeupPriceTB.Text);
            int makeupWeight = int.Parse(MakeupWeightTB.Text);
            int makeupTypeID = int.Parse(MakeupTypeIDTB.Text);
            int makeupBrandID = int.Parse(MakeupBrandIDTB.Text);

            string errorMessage = MakeupController.InsertMakeupValidator(makeupName, makeupPrice, makeupWeight, makeupTypeID, makeupBrandID);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                ErrLbl.Text = errorMessage;
                ErrLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MakeupController.InsertNewMakeup(makeupName, makeupPrice, makeupWeight, makeupTypeID, makeupBrandID);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void MakeupNameTB_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if necessary
        }

        protected void MakeupPriceTB_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if necessary
        }

        protected void MakeupBrandIDTB_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if necessary
        }
    }

}
