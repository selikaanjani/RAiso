using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserRepository userRepo = new UserRepository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String name = NameTxt.Text;
            String password = PasswordTxt.Text;
            bool isRemember = RememberCb.Checked;
            MsUser user = userRepo.GetUserByName(name);

            if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password))
            {
                ErrorLbl.Text = "All fields must be filled!";
            }
            else if(user == null)
            {
                ErrorLbl.Text = "Couldn't find your account!";
            }
            else if(user.UserPassword != password)
            {
                ErrorLbl.Text = "Wrong password!";
            }
            else
            {
                Session["user"] = user;
                
                if(isRemember == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = Convert.ToString(user.UserID);
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}