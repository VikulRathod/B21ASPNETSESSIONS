using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.BLL.Interfaces;
using VCart.Models;
using VCart.Repositories.Interfaces;

namespace VCart.BLL.Implementations
{
    public class RoleBL : IRoleBL
    {
        IRoleRepository _roleRepo = null;

        public RoleBL(IRoleRepository roleRepo)
        {
            _roleRepo = roleRepo;
        }
        public List<Role> GetRoles()
        {
            var roles = _roleRepo.AllRoles().
                Select(
                r => new Role() { RoleId = r.RoleId, RoleName = r.RoleName }
                );
            return roles.ToList();
        }
    }
}
