using System.Collections.Generic;
using Scraper.Roles.Dto;

namespace Scraper.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
