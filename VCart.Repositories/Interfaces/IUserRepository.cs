using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.DAL.Entities;

namespace VCart.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> AllUsers();

        User UserById(int id);

        bool InsertUser(User user);

        bool Updateuser(User user);

        bool DeleteUser(int id);
    }
}
