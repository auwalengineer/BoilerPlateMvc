using Abp.AutoMapper;
using BoilerPlateMvc.Roles.Dto;
using BoilerPlateMvc.Web.Models.Common;

namespace BoilerPlateMvc.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
