using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace RAiso.Factories
{
    public class UserFactory
    {
        public static MsUser Create(int id, String name, String gender, DateTime dob, String phone, String address, String password, String role)
        {
            MsUser user = new MsUser();
            user.UserID = id;
            user.UserName = name;
            user.UserGender = gender;
            user.UserDOB = dob;
            user.UserPhone = phone;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserRole = role;
            return user;
        }
    }
}