using RAiso.Controllers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();
            }
        }

        private void Show_Data()
        {
            int UserID = GetUserId();
            MsUser user = userController.getUserByID(UserID);

            NameTxt.Text = user.UserName;
            DobTxt.Text = user.UserDOB.ToString("yyyy-MM-dd");
            if (user.UserGender == "Male")
            {
                MaleBtn.Checked = true;
            }
            else if (user.UserGender == "Female")
            {
                FemaleBtn.Checked = true;
            }
            PhoneTxt.Text = user.UserPhone.ToString();
            AddressTxt.Text = user.UserAddress.ToString();
            PasswordTxt.Text = user.UserPassword;
        }

        private int GetUserId()
        {
            MsUser user = (MsUser)Session["user"];
            return user.UserID;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            String name = NameTxt.Text;
            String dob = DobTxt.Text;
            String address = AddressTxt.Text;
            String password = PasswordTxt.Text;
            String phone = PhoneTxt.Text;
            String response = userController.DoUpdate(GetUserId(), name, dob, MaleBtn, FemaleBtn, phone, address, password);

            if (response.Equals("Update success!") == true)
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