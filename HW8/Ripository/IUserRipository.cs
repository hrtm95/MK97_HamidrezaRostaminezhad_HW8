﻿using HW8.Models;

namespace HW8.Ripository
{
    public interface IUserRipository
    {
        List<User> GetUsers();
        User GetUserByEmail(string email);
        bool Login(string username, string password);
        


    }
}
