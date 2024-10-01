using MakeMeUpzz.Controller;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void TransactionDetailsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string transactionId = button.CommandArgument;
            Response.Redirect("~/Views/TransactionDetail.aspx?TransactionID=" + transactionId);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HeaderUser.Visible = false;
            HeaderAdmin.Visible = false;
            User currentUser = null;

            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
                return;
            }

            if (Session["user_session"] == null)
            {
                string cookieId = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(cookieId, out int userId))
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

            List<TransactionHeader> transactionHeaders = null;
            TransactionHistoryController transactionController = new TransactionHistoryController();

            if (currentUser.UserRole.Equals("User"))
            {
                HeaderUser.Visible = true;
                transactionHeaders = transactionController.GetByUserId(currentUser.UserID);
            }
            else if (currentUser.UserRole.Equals("Admin"))
            {
                HeaderAdmin.Visible = true;
                transactionHeaders = transactionController.GetAllTransactionHeaders();
            }

            if (!IsPostBack)
            {
                HeaderUser.DataSource = transactionHeaders;
                HeaderUser.DataBind();
                HeaderAdmin.DataSource = transactionHeaders;
                HeaderAdmin.DataBind();
            }
        }

        

    }
}
