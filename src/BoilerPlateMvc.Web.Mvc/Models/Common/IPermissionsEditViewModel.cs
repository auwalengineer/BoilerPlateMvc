using System.Collections.Generic;
using BoilerPlateMvc.Roles.Dto;

namespace BoilerPlateMvc.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}