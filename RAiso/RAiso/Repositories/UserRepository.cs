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

        public MsUser GetLastUser()
        {
            return(from x in db.MsUsers
                   select x).ToList().LastOrDefault();
        }

        public bool IsNameUnique(String name)
        {
            MsUser user = (from x in db.MsUsers
                           where x.UserName == name
                           select x).FirstOrDefault();

            if(user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MsUser GetUserByName(String name)
        {
            return(from x in db.MsUsers
                    where x.UserName == name
                    select x).FirstOrDefault();
        }
    }
}