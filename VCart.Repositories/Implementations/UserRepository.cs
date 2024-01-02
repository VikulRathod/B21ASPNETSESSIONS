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
            throw new NotImplementedException();
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
    }
}
