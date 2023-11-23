using DAL;
using Models;

namespace BLL
{
    public class UsersBL : IUsersBL
    {
        IUsersDB _db;

        public UsersBL(IUsersDB db)
        {
            _db = db;
        }

        public bool Insert(User user, out int registrationNumber)
        {
            // UsersDB db = new UsersDB();
            return _db.Insert(user, out registrationNumber);
        }
    }
}
