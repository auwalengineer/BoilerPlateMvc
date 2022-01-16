using Abp.MultiTenancy;
using BoilerPlateMvc.Authorization.Users;

namespace BoilerPlateMvc.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
