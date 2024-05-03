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
        RAisoDatabaseEntities db = DatabaseSingleton.GetInstance();

        public void CreateUser(int id, String name, String gender, DateTime dob, String phone, String address, String password, String role)
        {
            MsUser user = UserFactory.Create(id, name, gender, dob, phone, address, password, role);
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public int GetLastUserId()
        {
            return (from x in db.MsUsers
                    select x.UserID).LastOrDefault();
        }
    }
}