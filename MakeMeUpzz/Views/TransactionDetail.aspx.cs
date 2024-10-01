using MakeMeUpzz.Controller;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DetailUser.Visible = false;
            DetailAdmin.Visible = false;
            User currentUser = null;

            List<Models.TransactionDetail> transactionDetails = null;
            TransactionDetailController transactionDetailController = new TransactionDetailController();
            string transactionId = Request.QueryString["TransactionID"];
            int tid = Convert.ToInt32(transactionId);

            if (currentUser.UserRole.Equals("User"))
            {
                DetailUser.Visible = true;
                transactionDetails = TransactionDetailController.FindByTransactionId(tid);
            }
            else if (currentUser.UserRole.Equals("Admin"))
            {
                DetailAdmin.Visible = true;
                transactionDetails = TransactionDetailController.GetAllTransactionDetails();
            }

            if (!IsPostBack)
            {
                TransactionHistoryController transactionHistoryController = new TransactionHistoryController();
                DetailUser.DataSource = transactionDetails;
                DetailUser.DataBind();
                DetailAdmin.DataSource = transactionDetails;
                DetailAdmin.DataBind();
            }
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

      
            
        }
    }
}
