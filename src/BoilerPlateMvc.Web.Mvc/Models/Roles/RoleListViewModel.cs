using System.Collections.Generic;
using BoilerPlateMvc.Roles.Dto;

namespace BoilerPlateMvc.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
