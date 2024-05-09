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

        public int GetRegisteredId()
        {
            MsUser user = db.MsUsers.ToList().LastOrDefault();
            if (user == null)
            {
                return 1;
            }
            else
            {
                return user.UserID + 1;
            }
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
    }
}