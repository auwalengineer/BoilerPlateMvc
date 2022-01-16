using System.Threading.Tasks;
using BoilerPlateMvc.Models.TokenAuth;
using BoilerPlateMvc.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerPlateMvc.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerPlateMvcWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}