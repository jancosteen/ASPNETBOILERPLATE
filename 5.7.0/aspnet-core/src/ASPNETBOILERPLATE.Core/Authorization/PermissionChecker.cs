using Abp.Authorization;
using ASPNETBOILERPLATE.Authorization.Roles;
using ASPNETBOILERPLATE.Authorization.Users;

namespace ASPNETBOILERPLATE.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
