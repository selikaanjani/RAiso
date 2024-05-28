using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handlers
{
    public class UserHandler
    {
        UserRepository userRepo = new UserRepository();

        public void Register(String name, String gender, DateTime dob, String phone, String address, String password, String role)
        {
            MsUser user = userRepo.GetUserByName(name);
            int id = GetRegisteredId();

            if (user == null)
            {
                userRepo.RegisterUser(id, name, gender, dob, phone, address, password, role);
            }
        }

        public MsUser Login(String name, String password)
        {
            MsUser user = userRepo.LoginUser(name, password);
            return user;
        }

        public void Update(int id, String name, String gender, DateTime dob, String phone, String address, String password)
        {
            userRepo.UpdateUser(id, name, gender, dob, phone, address, password);
        }

        public MsUser GetUserByName(String name)
        {
            MsUser user = userRepo.GetUserByName(name);
            return user;
        }

        public MsUser GetUserById(int id)
        {
            MsUser user = userRepo.GetUserById(id);
            return user;
        }

        public int GetRegisteredId()
        {
            MsUser user = userRepo.GetLastUser();
            int id;

            if (user == null)
            {
                 id = 1;
            } 
            else
            {
                id = user.UserID + 1;
            }

            return id;
        }

        public String GetUserByRole(String role)
        {
            string roles = userRepo.GetRoles(role);
            return roles;
        }
    }
}