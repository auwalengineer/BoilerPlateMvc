using Abp.Authorization;
using BoilerPlateMvc.Authorization.Roles;
using BoilerPlateMvc.Authorization.Users;

namespace BoilerPlateMvc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
