using Abp.Authorization;
using Scraper.Authorization.Roles;
using Scraper.Authorization.Users;

namespace Scraper.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
