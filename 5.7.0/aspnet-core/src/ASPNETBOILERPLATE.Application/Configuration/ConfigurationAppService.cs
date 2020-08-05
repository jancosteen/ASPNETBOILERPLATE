using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ASPNETBOILERPLATE.Configuration.Dto;

namespace ASPNETBOILERPLATE.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ASPNETBOILERPLATEAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
