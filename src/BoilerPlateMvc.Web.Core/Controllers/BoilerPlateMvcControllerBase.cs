using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BoilerPlateMvc.Controllers
{
    public abstract class BoilerPlateMvcControllerBase: AbpController
    {
        protected BoilerPlateMvcControllerBase()
        {
            LocalizationSourceName = BoilerPlateMvcConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
