using MakeMeUpzz.Controller;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class OrderMakeup : System.Web.UI.Page
    {
        public List<Makeup> makeupList = null;

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
                string userIdCookie = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(userIdCookie, out int userId))
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
                makeupList = OrderController.GetAllMakeups();
                MakeUpGV.DataSource = makeupList;
                MakeUpGV.DataBind();
            }
        }

        protected void ClearTransaction_Click(object sender, EventArgs e)
        {
            OrderController.EmptyCart();
        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            // Implementation needed
        }

        protected void MakeUpGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Order")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = MakeUpGV.Rows[rowIndex];

                TextBox quantityTextBox = (TextBox)row.FindControl("QuantityTextBox");
                if (quantityTextBox != null)
                {
                    if (int.TryParse(quantityTextBox.Text, out int quantity) && quantity > 0)
                    {
                        int makeupId = Convert.ToInt32(MakeUpGV.DataKeys[rowIndex].Value);
                        User currentUser = Session["user_session"] as User;

                        if (currentUser != null)
                        {
                            int userId = currentUser.UserID;
                            CartsController.InsertToCart(userId, makeupId, quantity);
                            Response.Redirect("~/Views/OrderMakeup.aspx");
                        }
                        else
                        {
                            Debug.WriteLine("User is not logged in.");
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Invalid quantity entered.");
                    }
                }
                else
                {
                    Debug.WriteLine("QuantityTextBox not found.");
                }
            }
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            User currentUser = Session["user_session"] as User;
            DateTime now = DateTime.Now;
            int userId = currentUser.UserID;
            string status = "Unhandled";
            int transactionId = TransactionHistoryController.GenerateTransactionId();

            TransactionHistoryController transactionHistory = new TransactionHistoryController();
            transactionHistory.InsertTransactionHeader(transactionId, userId, now, status);

            List<Cart> cartItems = CartsController.GetAllCartItems();
            foreach (var item in cartItems)
            {
                TransactionDetailController transactionDetail = new TransactionDetailController();
                transactionDetail.InsertTransactionDetail(transactionId, item.MakeupID, item.Quantity);
            }

            OrderController.EmptyCart();
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}
