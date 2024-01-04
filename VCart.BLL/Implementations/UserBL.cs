using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.BLL.Interfaces;
using VCart.Models;
using VCart.Repositories.Interfaces;
using dal = VCart.DAL.Entities;

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

        public bool CreateUser(User user)
        {
            dal.User u = new dal.User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                DateOfBirth = user.DateOfBirth,
                RoleId = 4
            };

            return _userRepo.InsertUser(u);
        }

        public User AuthenticateUser(string email, string password)
        {
            var user = _userRepo.AuthenticateUser(email, password);

            if (user != null)
            {
                User dbUser = new User()
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    DateOfBirth = user.DateOfBirth,
                    RoleId = user.RoleId,
                    Role = new Role() 
                    { RoleId = user.Role?.RoleId ?? 0, RoleName = user.Role?.RoleName }
                };

                return dbUser;
            }
            return null;
        }
    }
}
