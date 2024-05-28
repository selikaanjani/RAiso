using RAiso.Factories;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace RAiso.Repositories
{
    public class UserRepository
    {
        private RAisoDatabaseEntities db = DatabaseSingleton.GetInstance();

        public void RegisterUser(int id, String name, String gender, DateTime dob, String phone, String address, String password, String role)
        {
            MsUser user = UserFactory.Create(id, name, gender, dob, phone, address, password, role);
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public void UpdateUser(int id, String name, String gender, DateTime dob, String phone, String address, String password)
        {
            MsUser user = GetUserById(id);
            user.UserName = name;
            user.UserGender = gender;
            user.UserDOB = dob;
            user.UserPhone = phone;
            user.UserAddress = address;
            user.UserPassword = password;
            db.SaveChanges();
        }

        public MsUser GetLastUser()
        {
            return (from x in db.MsUsers
                    select x).ToList().LastOrDefault();
        }

        public MsUser GetUserByName(String name)
        {
            return (from x in db.MsUsers
                    where x.UserName.Equals(name)
                    select x).FirstOrDefault();
        }

        public MsUser LoginUser(String name, String password)
        {
            return (from x in db.MsUsers
                    where x.UserName.Equals(name) && x.UserPassword.Equals(password)
                    select x).FirstOrDefault();
        }

        public MsUser GetUserById(int id)
        {
            return (from x in db.MsUsers
                    where x.UserID == id
                    select x).FirstOrDefault();
        }

        public String GetRoles(String role)
        {
            return (from x in db.MsUsers
                    select x.UserRole).FirstOrDefault();
        }


    }
}