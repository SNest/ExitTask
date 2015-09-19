namespace ExitTask.Application.Providers
{
    using System;
    using System.Linq;
    using System.Web.Security;

    using ExitTask.Domain.Abstract.UnitOfWork;

    using Ninject;

    public class ExitTaskRoleProvider : RoleProvider
    {
        [Inject]
        private IUnitOfWork unitOfWork { get; set; }

        public override string[] GetRolesForUser(string email)
        {
            var role = this.unitOfWork.Users.GetAll().FirstOrDefault(u => u.Email == email);
            if (role == null) return null;
            string[] result = { role.Role.ToString() };
            return result;
        }

        #region NotImplemented

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
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

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}