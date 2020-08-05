using System.Threading.Tasks;
using ASPNETBOILERPLATE.Models.TokenAuth;
using ASPNETBOILERPLATE.Web.Controllers;
using Shouldly;
using Xunit;

namespace ASPNETBOILERPLATE.Web.Tests.Controllers
{
    public class HomeController_Tests: ASPNETBOILERPLATEWebTestBase
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