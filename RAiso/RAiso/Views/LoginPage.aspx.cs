using RAiso.Controllers;
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
        UserController userController = new UserController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String name = NameTxt.Text;
            String password = PasswordTxt.Text;
            String response = userController.DoLogin(name, password, RememberCb);

            if (response.Equals("Login success!") == true)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else
            {
                ErrorLbl.Text = response;
            }
        }
    }
}