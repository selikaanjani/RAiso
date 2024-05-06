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
        UserRepository userRepo = new UserRepository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            int id = GenerateId();
            String name = NameTxt.Text;
            String dob = DobTxt.Text;
            String gender = "";
            if(MaleBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            String address = AddressTxt.Text;
            String password = PasswordTxt.Text;
            String phone = PhoneTxt.Text;

            if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(dob) || String.IsNullOrEmpty(gender) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(phone))
            {
                ErrorLbl.Text = "All fields must be filled!";
            }
            else if(NameValidation(name) == false)
            {
                ErrorLbl.Text = "Name must be between 5 and 50 characters and unique!";
            }
            else if(DobValidation(Convert.ToDateTime(dob)) == false)
            {
                ErrorLbl.Text = "Age must be at least 1 year!";
            }
            else if(PasswordValidation(password) == false) 
            {
                ErrorLbl.Text = "Password must be alphanumeric!";
            }
            else
            {
                userRepo.CreateUser(id, name, gender, Convert.ToDateTime(dob), phone, address, password, "Customer");
                Response.Redirect("~/Views/LoginPage.aspx");
            }
        }

        public int GenerateId()
        {
            MsUser user = userRepo.GetLastUser();

            if(user == null)
            {
                return 1;
            }
            else
            {
                int lastId = user.UserID;
                lastId++;
                return lastId;
            }
        }

        public bool NameValidation(String name)
        {
            if(userRepo.IsNameUnique(name) == false)
            {
                return false;
            }
            if(name.Length < 5 || name.Length > 50)
            {
                return false;
            }
            return true;
        }

        public bool DobValidation(DateTime dob)
        {
            if (dob >= DateTime.Today.AddYears(-1))
            {
                return false;
            }
            return true;
        }

        public bool PasswordValidation(String password)
        {
            for(int i = 0; i < password.Length; i++)
            {
                if (!(char.IsLetter(password[i]) && !char.IsDigit(password[i])))
                {
                    return false;
                }
            }
            return true;
        }
    }
}