using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateMvc.EntityFrameworkCore;
using BoilerPlateMvc.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BoilerPlateMvc.Web.Tests
{
    [DependsOn(
        typeof(BoilerPlateMvcWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BoilerPlateMvcWebTestModule : AbpModule
    {
        public BoilerPlateMvcWebTestModule(BoilerPlateMvcEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateMvcWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BoilerPlateMvcWebMvcModule).Assembly);
        }
    }
}