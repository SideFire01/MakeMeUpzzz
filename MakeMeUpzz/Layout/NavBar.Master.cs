using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Layout
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentUser = Session["user_session"] as User;
            if (currentUser == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }

            string userRole = currentUser.UserRole;
            if (userRole.Equals("Admin"))
            {
                HomeButton.Visible = true;
                ManageMakeupButton.Visible = true;
                OrderQbutton.Visible = true;
                TransactionReport.Visible = true;
                OrderMakeupButton.Visible = false;


            }
            else
            {
                HomeButton.Visible = false;
                ManageMakeupButton.Visible = false;
                OrderQbutton.Visible = false;
                TransactionReport.Visible = false;
                OrderMakeupButton.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();

            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void ManageMakeupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void OrderQbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHandler.aspx");
        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void TransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionReport.aspx");
        }

        protected void OrderMakeupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderMakeup.aspx");
        }

        protected void HistoryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistory.aspx");

        }
    }
}