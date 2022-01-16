using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlateMvc.Sessions.Dto;

namespace BoilerPlateMvc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
