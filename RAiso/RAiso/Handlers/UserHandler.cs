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
            int id = userRepo.GetRegisteredId();

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
    }
}