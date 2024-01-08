using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Security;
using VCart.BLL.Implementations;
using VCart.BLL.Interfaces;
using VCart.Repositories.Implementations;

namespace VCart.Web.App_Start
{
    public class UserRoleProvider : RoleProvider
    {
        UserBL _userBL = new UserBL(new UserRepository(new DAL.Entities.ProductDbContext()));
        RoleBL _roleBL = new RoleBL(new RoleRepository(new DAL.Entities.ProductDbContext()));

        //IRoleBL _roleBL = null;
        //IUserBL _userBL = null;

        //public UserRoleProvider(IRoleBL roleBL, IUserBL userBL)
        //{
        //    _roleBL = roleBL;
        //    _userBL = userBL;
        //}

        // private string _connectionString = "ProductDbContext";

        public override string ApplicationName
        {
            get;set;
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            var userRoles = from u in _userBL.AllUsers()
                            join r in _roleBL.GetRoles()
                            on u.RoleId equals r.RoleId
                            where u.Email == username
                            select r.RoleName;

            return userRoles.ToArray<string>();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            

            var userRoles = from u in _userBL.AllUsers()
                            join r in _roleBL.GetRoles()
                            on u.RoleId equals r.RoleId
                            where r.RoleName == roleName
                            select u.Email;

            return userRoles.ToArray<string>();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            var userRoles = from u in _userBL.AllUsers()
                            join r in _roleBL.GetRoles()
                            on u.RoleId equals r.RoleId
                            where u.Email == username &&
                            r.RoleName == roleName
                            select r.RoleName;

            return userRoles.Any();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}