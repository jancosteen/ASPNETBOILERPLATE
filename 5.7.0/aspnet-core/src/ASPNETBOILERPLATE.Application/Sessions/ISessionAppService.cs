using System.Threading.Tasks;
using Abp.Application.Services;
using ASPNETBOILERPLATE.Sessions.Dto;

namespace ASPNETBOILERPLATE.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
