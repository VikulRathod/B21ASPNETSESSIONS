using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.DAL.Entities;

namespace VCart.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> AllRoles();

        Role RoleById(int id);

        bool InsertRole(Role role);

        bool UpdateRole(Role role);

        bool DeleteRole(int id);
    }
}
