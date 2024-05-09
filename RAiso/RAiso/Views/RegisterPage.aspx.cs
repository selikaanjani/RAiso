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
    public partial class RegisterPage : System.Web.UI.Page
    {
        UserController userController = new UserController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            String name = NameTxt.Text;
            String dob = DobTxt.Text;
            String address = AddressTxt.Text;
            String password = PasswordTxt.Text;
            String phone = PhoneTxt.Text;
            String response = userController.DoRegister(name, dob, MaleBtn, FemaleBtn, phone, address, password, "Customer");

            if (response.Equals("Registration success!") == true)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                ErrorLbl.Text = response;
            }
        }
    }
}