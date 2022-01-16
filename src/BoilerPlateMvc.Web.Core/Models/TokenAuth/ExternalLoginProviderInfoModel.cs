using Abp.AutoMapper;
using BoilerPlateMvc.Authentication.External;

namespace BoilerPlateMvc.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
