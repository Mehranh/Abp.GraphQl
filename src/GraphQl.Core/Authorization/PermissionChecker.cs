using Abp.Authorization;
using GraphQl.Authorization.Roles;
using GraphQl.Authorization.Users;

namespace GraphQl.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
