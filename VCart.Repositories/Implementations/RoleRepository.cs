using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.DAL.Entities;
using VCart.Repositories.Interfaces;

namespace VCart.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        ProductDbContext _db = null;

        public RoleRepository(ProductDbContext db)
        {
            _db = db;
        }

        public List<Role> AllRoles()
        {
            return _db.Roles.ToList();
        }

        public bool DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertRole(Role role)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Role RoleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
