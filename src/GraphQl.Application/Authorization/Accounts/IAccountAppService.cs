using System.Threading.Tasks;
using Abp.Application.Services;
using GraphQl.Authorization.Accounts.Dto;

namespace GraphQl.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
