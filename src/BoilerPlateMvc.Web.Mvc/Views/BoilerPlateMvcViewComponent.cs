using Abp.AspNetCore.Mvc.ViewComponents;

namespace BoilerPlateMvc.Web.Views
{
    public abstract class BoilerPlateMvcViewComponent : AbpViewComponent
    {
        protected BoilerPlateMvcViewComponent()
        {
            LocalizationSourceName = BoilerPlateMvcConsts.LocalizationSourceName;
        }
    }
}
