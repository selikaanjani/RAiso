using RAiso.Controllers;
using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Layouts
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        UserController userController = new UserController();
        UserHandler userHandler = new UserHandler();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Guest
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                LoginLink.Visible = true;
                HomeLink.Visible = true;
                RegisterLink.Visible = true;
            }
            else
            {
                MsUser user;

                if (Session["user"] == null)
                {
                    int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = userHandler.GetUserById(id);
                    Session["user"] = user;
                }
                else
                {
                    user = (MsUser)Session["user"];
                }
                //customer
                if (user.UserRole.Equals("Customer"))
                {
                    HomeLink.Visible = true;
                    UpdateProfileLink.Visible = true;
                    CartLink.Visible = true;
                    CustomerTransactionLink.Visible = true;
                    LogoutBtn.Visible = true;
                }
                else
                //admin
                {
                    HomeLink.Visible = true;
                    UpdateLink.Visible = true;
                    AdminTransactionLink.Visible = true;
                    LogoutBtn.Visible = true;
                }
            }
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            userController.DoLogout();
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}