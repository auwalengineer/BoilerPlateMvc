using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateMvc.Configuration;

namespace BoilerPlateMvc.Web.Host.Startup
{
    [DependsOn(
       typeof(BoilerPlateMvcWebCoreModule))]
    public class BoilerPlateMvcWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerPlateMvcWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateMvcWebHostModule).GetAssembly());
        }
    }
}
