using Abp.AutoMapper;
using BoilerPlateMvc.Sessions.Dto;

namespace BoilerPlateMvc.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
