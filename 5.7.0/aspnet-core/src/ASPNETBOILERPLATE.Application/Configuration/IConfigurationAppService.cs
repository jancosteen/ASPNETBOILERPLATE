using System.Threading.Tasks;
using ASPNETBOILERPLATE.Configuration.Dto;

namespace ASPNETBOILERPLATE.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
