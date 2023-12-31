﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(long Id);
        void InsertUser(User user);
        void UpdatetUser(User user);
        void DeleteUser(long Id);
    }
}
