using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.Models;

namespace VCart.BLL.Interfaces
{
    public interface IUserBL
    {
        List<User> AllUsers();

        bool CreateUser(User user);

        User AuthenticateUser(string email, string password);
    }
}
