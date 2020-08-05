using System.Threading.Tasks;
using Abp.Application.Services;
using ASPNETBOILERPLATE.Authorization.Accounts.Dto;

namespace ASPNETBOILERPLATE.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
