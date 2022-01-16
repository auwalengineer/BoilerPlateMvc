using Abp.Application.Services;
using BoilerPlateMvc.MultiTenancy.Dto;

namespace BoilerPlateMvc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

