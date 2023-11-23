using Models;

namespace DAL
{
    public interface IUsersDB
    {
        bool Insert(User user, out int registrationNumber);
    }
}
