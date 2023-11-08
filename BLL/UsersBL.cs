using DAL;
using Models;

namespace BLL
{
    public class UsersBL
    {
        public bool Insert(User user, out int registrationNumber)
        {
            UsersDB db = new UsersDB();
            return db.Insert(user, out registrationNumber);
        }
    }
}
