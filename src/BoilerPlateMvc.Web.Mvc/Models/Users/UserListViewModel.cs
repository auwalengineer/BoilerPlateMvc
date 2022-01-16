using System.Collections.Generic;
using BoilerPlateMvc.Roles.Dto;

namespace BoilerPlateMvc.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
