using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GraphQl.MultiTenancy.Dto;

namespace GraphQl.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

