using System.Threading.Tasks;
using Abp.Application.Services;
using GraphQl.Sessions.Dto;

namespace GraphQl.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
