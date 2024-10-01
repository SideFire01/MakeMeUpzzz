
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
    public partial class UpdateMakeupBrand : System.Web.UI.Page
    {
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
                string id = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(id, out int userId))
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

            if (currentUser.UserRole.Equals("Admin") && !IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                MakeupBrand makeupBrand = MakeupController.FindMakeupBrandId(id);

                if (makeupBrand != null)
                {
                    updatembnametb.Text = makeupBrand.MakeupBrandName;
                    updatembratetb.Text = makeupBrand.MakeupBrandRating.ToString();
                }
                else
                {
                    Response.Redirect("~/Views/ManageMakeup.aspx");
                }
            }
        }

        protected void updatebtn_Click1(object sender, EventArgs e)
        {
            int updateID = Convert.ToInt32(Request.QueryString["id"]);
            string makeupName = updatembnametb.Text;
            int makeupRating = Convert.ToInt32(updatembratetb.Text);

            string errorMessage = MakeupController.MakeupBrandValidator(makeupName, makeupRating);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorMsgLabel.Text = errorMessage;
                errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MakeupController.UpdateMakeupBrand(updateID, makeupName, makeupRating);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }

        protected void backto_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }
    }
}

