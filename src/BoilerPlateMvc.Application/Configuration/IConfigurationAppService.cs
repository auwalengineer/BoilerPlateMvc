using System.Threading.Tasks;
using BoilerPlateMvc.Configuration.Dto;

namespace BoilerPlateMvc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
