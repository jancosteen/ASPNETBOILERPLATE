using Abp.Application.Services;
using ASPNETBOILERPLATE.MultiTenancy.Dto;

namespace ASPNETBOILERPLATE.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

