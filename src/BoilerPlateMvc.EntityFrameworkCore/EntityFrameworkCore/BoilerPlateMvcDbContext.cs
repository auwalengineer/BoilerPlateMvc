using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BoilerPlateMvc.Authorization.Roles;
using BoilerPlateMvc.Authorization.Users;
using BoilerPlateMvc.MultiTenancy;

namespace BoilerPlateMvc.EntityFrameworkCore
{
    public class BoilerPlateMvcDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerPlateMvcDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerPlateMvcDbContext(DbContextOptions<BoilerPlateMvcDbContext> options)
            : base(options)
        {
        }
    }
}
