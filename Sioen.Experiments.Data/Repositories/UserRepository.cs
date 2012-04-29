﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sioen.Experiments.Data.Entities;

namespace Sioen.Experiments.Data.Repositories
{
    public static class UserRepository
    {
        public static IQueryable<User> AllUsersOlderThan(this IQueryable<User> users, int age)
        {
            return from u in users
                   where u.BirthDate.Date < DateTime.Now.Date.AddYears(-age)
                   select u;
        }
    }
}