using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.DAL.Entities;
using VCart.Repositories.Interfaces;

namespace VCart.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        ProductDbContext _db = null;

        public UserRepository(ProductDbContext db)
        {
            _db = db;
        }

        public List<User> AllUsers()
        {
            return _db.Users.ToList();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertUser(User user)
        {
            try
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Updateuser(User user)
        {
            throw new NotImplementedException();
        }

        public User UserById(int id)
        {
            User user = _db.Users.Find(id);
            return user;
        }

        public User AuthenticateUser(string email, string password)
        {
            try
            {
                User user = _db.Users.Include("Role").FirstOrDefault(u =>
                u.Email.Equals(email) && u.Password.Equals(password));

                return user;
            }
            catch
            {
                return null;
            }
        }
    }
}
