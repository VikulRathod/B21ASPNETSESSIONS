﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.BLL.Interfaces;
using VCart.Models;
using VCart.Repositories.Interfaces;

namespace VCart.BLL.Implementations
{
    // use UserRepository
    public class UserBL : IUserBL
    {
        IUserRepository _userRepo = null;

        public UserBL(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public List<User> AllUsers()
        {
            return _userRepo.AllUsers().Select(u =>
            new User()
            {
                UserId = u.UserId,
                Name = u.Name,
                DateOfBirth = u.DateOfBirth,
                Email = u.Email,
                Password = u.Password,
                RoleId = u.RoleId
            }).ToList();
        }
    }
}
