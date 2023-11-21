using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIP
{
    // high level module
    public class UsersBL
    {
        IUsersDAL _dal;
        public UsersBL(IUsersDAL dal)
        {
            _dal = dal;
        }

        public void Insert()
        {
            // UsersDAL dal = new UsersDAL();
            _dal.Insert();
        }
    }
}
