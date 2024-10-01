using MakeMeUpzz.Controller;
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
    public partial class TransactionHandler : System.Web.UI.Page
    {
        public List<TransactionHeader> transactionHeaders = null;
        TransactionHistoryController transactionController = new TransactionHistoryController();

        protected void thgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = thgv.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text;
            int transactionID = Convert.ToInt32(id);
            TransactionHeader transactionHeader = transactionController.SearchTransaction(transactionID);
            string newStatus = "handled";

            transactionController.UpdateStatus(transactionID, newStatus);

            Response.Redirect("~/Views/HomePage.aspx");
        }
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

            if (!IsPostBack)
            {
                transactionHeaders = transactionController.GetUnhandledTransaction("Unhandled");
                thgv.DataSource = transactionHeaders;
                thgv.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        
    }
}
