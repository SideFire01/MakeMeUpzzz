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
    public partial class UpdateMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_session"] == null && Response.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                User user = new User();
                if (Session["user_session"] == null)
                {
                    int userID = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = UserController.FindUser(userID);
                    Session["user_session"] = user;
                }
                else
                {
                    user = (User)Session["user_session"];
                }

                if (user.UserRole.Equals("Admin") && !IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    Makeup makeup = MakeupController.FindById(id);
                    UpdateMakeupView.Visible = true;

                    if (makeup != null)
                    {
                        MakeupNameTB.Text = makeup.MakeupName;
                        MakeupPriceTB.Text = makeup.MakeupPrice.ToString();
                        MakeupWeightTB.Text = makeup.MakeupWeight.ToString();
                        MakeupTypeIDTB.Text = makeup.MakeupTypeID.ToString();
                        MakeupBrandIDTB.Text = makeup.MakeupBrandID.ToString();
                    }
                    else
                    {
                        Response.Redirect("~/Views/ManageMakeup.aspx");
                    }
                }
            }
        }

        protected void UpdateMakeupBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            String MakeupName = MakeupNameTB.Text;
            int MakeupPrice = Convert.ToInt32(MakeupPriceTB.Text);
            int MakeupWeight = Convert.ToInt32(MakeupWeightTB.Text);
            int MakeupTypeID = Convert.ToInt32(MakeupTypeIDTB.Text);
            int MakeupBrandID = Convert.ToInt32(MakeupBrandIDTB.Text);
            string errorMessage = MakeupController.InsertMakeupValidator(MakeupName, MakeupPrice, MakeupWeight,
                MakeupTypeID, MakeupBrandID);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                ErrorLbl.Text = errorMessage;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MakeupController.UpdateMakeup(id, MakeupName, MakeupPrice, MakeupWeight,
                    MakeupTypeID, MakeupBrandID);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }
    }
}
