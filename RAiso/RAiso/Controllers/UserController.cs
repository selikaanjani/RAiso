using RAiso.Handlers;
using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RAiso.Controllers
{
    public class UserController
    {
        private UserHandler userHandler = new UserHandler();

        public String DoRegister(String name, String dob, RadioButton maleBtn, RadioButton femaleBtn, String phone, String address, String password, String role)
        {
            String gender = "";

            if (maleBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(dob) || (maleBtn.Checked == false && femaleBtn.Checked == false) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(phone))
            {
                return "All fields must be filled!";
            }
            else if (NameValidation(name) == false)
            {
                return "Name must be between 5 and 50 characters and unique!";
            }
            else if (DobValidation(Convert.ToDateTime(dob)) == false)
            {
                return "Age must be at least 1 year!";
            }
            else if (PasswordValidation(password) == false)
            {
                return "Password must be alphanumeric!";
            }
            else
            {
                userHandler.Register(name, gender, Convert.ToDateTime(dob), phone, address, password, role);
                return "Registration success!";
            }
        }

        public String DoLogin(String name, String password, CheckBox rememberMe)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password))
            {
                return "All fields must be filled!";
            }
            else if (userHandler.GetUserByName(name) == null)
            {
                return "Couldn't find your account!";
            }
            else if (userHandler.Login(name, password) == null)
            {
                return "Wrong name or password!";
            }
            else
            {
                MsUser user = userHandler.Login(name, password);
                HttpContext.Current.Session["user"] = user;

                if (rememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = Convert.ToString(user.UserID);
                    cookie.Expires = DateTime.Now.AddDays(1);
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }

                return "Login success!";
            }
        }

        public bool NameValidation(String name)
        {
            if (name.Length < 5 || name.Length > 50 || userHandler.GetUserByName(name) != null)
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
            bool isLetter = false;
            bool isDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c) == true)
                {
                    isLetter = true;
                }

                if (char.IsDigit(c) == true)
                {
                    isDigit = true;
                }
            }

            if (isLetter == true && isDigit == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DoLogout()
        {
            HttpContext.Current.Session.Remove("user");
            HttpContext.Current.Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}