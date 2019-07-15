using System.Threading.Tasks;
using GraphQl.Configuration.Dto;

namespace GraphQl.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
